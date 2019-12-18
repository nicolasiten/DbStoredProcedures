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
                string insertIssueDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Seeder\Sql", "InsertIssueData.sql");
                await issueTrackerContext.Database.ExecuteSqlRawAsync(File.ReadAllText(insertIssueDataPath));
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
                    new IssueStatus { Id = 1, Name = "Open" },
                    new IssueStatus { Id = 2, Name = "In Progress" },
                    new IssueStatus { Id = 3, Name = "Resolved" }
                });

                await SaveWithIdentityInsertAsync(issueTrackerContext, nameof(IssueStatus));
            }

            if (!await issueTrackerContext.Set<OperatingSystem>().AnyAsync())
            {
                issueTrackerContext.OperatingSystem.AddRange(new[]
                {
                    new OperatingSystem { Id = 1, Name = "Linux" },
                    new OperatingSystem { Id = 2, Name = "MacOS" },
                    new OperatingSystem { Id = 3, Name = "Windows" },
                    new OperatingSystem { Id = 4, Name = "Android" },
                    new OperatingSystem { Id = 5, Name = "iOS" },
                    new OperatingSystem { Id = 6, Name = "Windows Mobile" }
                });

                await SaveWithIdentityInsertAsync(issueTrackerContext, nameof(OperatingSystem));
            }

            if (!await issueTrackerContext.Set<Product>().AnyAsync())
            {
                issueTrackerContext.Product.AddRange(new[]
                {
                    new Product { Id = 1, Name = "Day Trader Wannabe" },
                    new Product { Id = 2, Name = "Investment Overlord" },
                    new Product { Id = 3, Name = "Workout Planner" },
                    new Product { Id = 4, Name = "Social Anxiety Planner" },
                });

                await SaveWithIdentityInsertAsync(issueTrackerContext, nameof(Product));
            }

            if (!await issueTrackerContext.Set<Version>().AnyAsync())
            {
                issueTrackerContext.Version.AddRange(new[]
                {
                    new Version { Id = 1, VersionName = "1.0" },
                    new Version { Id = 2, VersionName = "1.1" },
                    new Version { Id = 3, VersionName = "1.2" },
                    new Version { Id = 4, VersionName = "1.3" },
                    new Version { Id = 5, VersionName = "2.0" },
                    new Version { Id = 6, VersionName = "2.1" },
                });

                await SaveWithIdentityInsertAsync(issueTrackerContext, nameof(Version));
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

        private static async Task SaveWithIdentityInsertAsync(IssueTrackerContext issueTrackerContext, string tableName)
        {
            issueTrackerContext.Database.OpenConnection();
            await issueTrackerContext.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT dbo.{tableName} ON");

            await issueTrackerContext.SaveChangesAsync();

            issueTrackerContext.Database.OpenConnection();
            await issueTrackerContext.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT dbo.{tableName} OFF");
        }
    }
}
