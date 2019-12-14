using DbStoredProcedures.Data;
using DbStoredProcedures.Data.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Threading.Tasks;

namespace DbStoredProcedures
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var serviceProvider = new ServiceProviderBuilder()
                .Build(config);

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            var dbContext = serviceProvider.GetRequiredService<IssueTrackerContext>();

            Console.Write("Type in number of issues you want to generate (Default: 0).: ");
            int numberOfIssues = 0;
            if (int.TryParse(Console.ReadLine(), out int numberOfIssuesInput))
            {
                numberOfIssues = numberOfIssuesInput;
            }                       

            await MigrateAndSeedDatabase(logger, dbContext, numberOfIssues);
        }

        private static async Task MigrateAndSeedDatabase(ILogger logger, IssueTrackerContext dbContext, int numberOfIssues)
        {
            logger.LogInformation("Migrate Database...");
            await dbContext.Database.MigrateAsync();

            logger.LogInformation("Seed Database...");
            await DbDataSeeder.Seed(numberOfIssues, dbContext);
            logger.LogInformation("Seeding done");
        }
    }
}
