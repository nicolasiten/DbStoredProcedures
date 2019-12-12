using DbStoredProcedures.Data;
using DbStoredProcedures.Data.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

            var dbContext = serviceProvider.GetRequiredService<IssueTrackerContext>();
            await dbContext.Database.MigrateAsync();

            await DbDataSeeder.Seed(10, dbContext);
        }
    }
}
