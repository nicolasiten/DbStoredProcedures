using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbStoredProcedures.Data.Seeder
{
    public static class DbDataSeeder
    {
        public static async Task SeedStaticDataAsync(IssueTrackerContext issueTrackerContext)
        {
            await SeedTables(issueTrackerContext);

            if (!await issueTrackerContext.Issue.AnyAsync())
            {
                string createStoredProcedures = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Seeder\Sql", "InsertIssueData.sql");
                issueTrackerContext.Issue.FromSqlRaw(File.ReadAllText(createStoredProcedures));
            }
        }

        public static async Task Seed(int numberOfIssues, IssueTrackerContext issueTrackerContext)
        {
            await SeedTables(issueTrackerContext);
            await SeedRandomIssues(numberOfIssues, issueTrackerContext);
        }

        private static async Task SeedRandomIssues(int numberOfIssues, IssueTrackerContext issueTrackerContext)
        {
            if (numberOfIssues > 0)
            {
                var productVersionOsEntities = await issueTrackerContext.Set<ProductVersionOs>().ToListAsync();

                for (int i = 0; i < numberOfIssues; i++)
                {
                    Issue issue = new Issue();
                    issue.CreationDate = RandomDataGenerator.GetRandomDate(DateTime.Now.AddDays(-20), DateTime.Now);

                    RandomDataGenerator.SetRandomProductVersionOs(productVersionOsEntities, issue);
                    string productName = (await issueTrackerContext.Set<Product>().FindAsync(issue.ProductFk)).Name;

                    issue.Problem = RandomDataGenerator.GetRandomProblem(productName);
                    issue.StatusFk = RandomDataGenerator.GetRandomNumber(1, 3);

                    if (RandomDataGenerator.GetRandomBool())
                    {
                        issue.StatusFk = 3;
                        issue.ResolutionDate = RandomDataGenerator.GetRandomDate(issue.CreationDate, DateTime.Now);
                        issue.Resolution = RandomDataGenerator.GetRandomResolution();
                    }

                    issueTrackerContext.Issue.Add(issue);
                }

                await issueTrackerContext.SaveChangesAsync();
            }
        }

        private static async Task SeedTables(IssueTrackerContext issueTrackerContext)
        {
            if (!await issueTrackerContext.Set<IssueStatus>().AnyAsync())
            {
                issueTrackerContext.IssueStatus.AddRange(new[]
                {
                    new IssueStatus { Name = "Open" },
                    new IssueStatus { Name = "In Progress" },
                    new IssueStatus { Name = "Resolved" }
                });

                await issueTrackerContext.SaveChangesAsync();
            }

            if (!await issueTrackerContext.Set<OperatingSystem>().AnyAsync())
            {
                issueTrackerContext.OperatingSystem.AddRange(new[]
                {
                    new OperatingSystem { Name = "Linux" },
                    new OperatingSystem { Name = "MacOS" },
                    new OperatingSystem { Name = "Windows" },
                    new OperatingSystem { Name = "Android" },
                    new OperatingSystem { Name = "iOS" },
                    new OperatingSystem { Name = "Windows Mobile" }
                });

                await issueTrackerContext.SaveChangesAsync();
            }

            if (!await issueTrackerContext.Set<Product>().AnyAsync())
            {
                issueTrackerContext.Product.AddRange(new[]
                {
                    new Product { Name = "Day Trader Wannabe" },
                    new Product { Name = "Investment Overlord" },
                    new Product { Name = "Workout Planner" },
                    new Product { Name = "Social Anxiety Planner" },
                });

                await issueTrackerContext.SaveChangesAsync();
            }

            if (!await issueTrackerContext.Set<Version>().AnyAsync())
            {
                issueTrackerContext.Version.AddRange(new[]
                {
                    new Version { VersionName = "1.0" },
                    new Version { VersionName = "1.1" },
                    new Version { VersionName = "1.2" },
                    new Version { VersionName = "1.3" },
                    new Version { VersionName = "2.0" },
                    new Version { VersionName = "2.1" },
                });

                await issueTrackerContext.SaveChangesAsync();
            }

            if (!await issueTrackerContext.Set<ProductVersionOs>().AnyAsync())
            {
                issueTrackerContext.ProductVersionOs.AddRange(new[]
                {
                    new ProductVersionOs { ProductFk = 1, VersionFk = 1, OperatingSystemFk = 1 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 1, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 1, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 1, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 1, OperatingSystemFk = 1 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 1, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 1, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 1, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 1, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 1, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 1, OperatingSystemFk = 6 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 2, OperatingSystemFk = 1 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 2, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 2, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 2, OperatingSystemFk = 1 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 2, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 2, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 2, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 2, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 2, OperatingSystemFk = 6 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 2, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 2, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 2, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 4, VersionFk = 2, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 3, OperatingSystemFk = 1 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 3, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 3, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 3, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 3, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 3, OperatingSystemFk = 6 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 4, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 4, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 4, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 1, VersionFk = 4, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 5, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 5, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 5, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 5, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 5, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 5, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 3, VersionFk = 5, OperatingSystemFk = 5 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 6, OperatingSystemFk = 2 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 6, OperatingSystemFk = 3 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 6, OperatingSystemFk = 4 },
                    new ProductVersionOs { ProductFk = 2, VersionFk = 6, OperatingSystemFk = 5 },
                });

                await issueTrackerContext.SaveChangesAsync();
            }            
        }
    }
}
