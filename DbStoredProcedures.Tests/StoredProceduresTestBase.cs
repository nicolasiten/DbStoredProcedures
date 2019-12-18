using DbStoredProcedures.Data;
using DbStoredProcedures.Data.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbStoredProcedures.Tests
{
    public abstract class StoredProceduresTestBase
    {
        protected readonly IssueTrackerContext IssueTrackerContext;

        protected StoredProceduresTestBase()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var dbContextOptions = new DbContextOptionsBuilder<IssueTrackerContext>()
                 .UseSqlServer(config.GetConnectionString("DbConnection"))
                 .Options;

            IssueTrackerContext = new IssueTrackerContext(dbContextOptions);
        }

        protected bool CheckResolvedState(IEnumerable<IssueStoredProcedureResult> issueStoredProcedureResults, bool resolved)
        {
            if (resolved)
            {
                return issueStoredProcedureResults.All(i => i.IssueStatusName == "Resolved");
            } 
            else
            {
                return !issueStoredProcedureResults.Any(i => i.IssueStatusName == "Resolved");
            }
        }

        protected bool CheckProductName(IEnumerable<IssueStoredProcedureResult> issueStoredProcedureResults, string productName)
        {
            return issueStoredProcedureResults.All(i => i.ProductName == productName);
        }

        protected bool CheckProductVersion(IEnumerable<IssueStoredProcedureResult> issueStoredProcedureResults, string version)
        {
            return issueStoredProcedureResults.All(i => i.Version == version);
        }

        protected bool CheckProductDateRange(IEnumerable<IssueStoredProcedureResult> issueStoredProcedureResults, DateTime fromDate, DateTime toDate)
        {
            return issueStoredProcedureResults.All(i => i.CreationDate >= fromDate && i.CreationDate <= toDate);
        }
    }
}
