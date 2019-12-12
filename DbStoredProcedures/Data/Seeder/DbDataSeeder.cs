using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbStoredProcedures.Data.Seeder
{
    public static class DbDataSeeder
    {
        private static readonly Random _random = new Random();

        public static async Task Seed(int numberOfIssues, IssueTrackerContext issueTrackerContext)
        {
            if (numberOfIssues > 0)
            {
                var productVersionOsEntities = await issueTrackerContext.Set<ProductVersionOs>().ToListAsync();

                for (int i = 0; i < numberOfIssues; i++)
                {
                    Issue issue = new Issue();
                    issue.CreationDate = GetRandomDate(DateTime.Now.AddDays(-20), DateTime.Now);

                    SetRandomProductVersionOs(productVersionOsEntities, issue);

                    issue.Problem = RandomProblemSolutionGenerator.GetRandomProblem();
                    issue.StatusFk = GetRandomNumber(1, 3);

                    if (GetRandomBool())
                    {
                        issue.StatusFk = 3;
                        issue.ResolutionDate = GetRandomDate(issue.CreationDate, DateTime.Now);
                        issue.Resolution = "test";
                    }

                    await issueTrackerContext.Issue.AddAsync(issue);
                }

                await issueTrackerContext.SaveChangesAsync();
            }
        }

        private static DateTime GetRandomDate(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newTimeSpan = new TimeSpan(0, _random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate + newTimeSpan;
        }

        private static int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private static bool GetRandomBool()
        {
            return _random.NextDouble() >= 0.5;
        }

        private static void SetRandomProductVersionOs(List<ProductVersionOs> productVersionOsEntities, Issue issue)
        {
            var productVersionOsEntity = productVersionOsEntities[GetRandomNumber(0, productVersionOsEntities.Count())];
            issue.OperatingSystemFk = productVersionOsEntity.OperatingSystemFk;
            issue.VersionFk = productVersionOsEntity.VersionFk;
            issue.ProductFk = productVersionOsEntity.ProductFk;
        }
    }
}
