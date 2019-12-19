using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByProductNameVersion : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(false, "Day Trader Wannabe", "1.1", 3)]
        [InlineData(false, "Social Anxiety Planner", "1.0", 3)]
        public async Task GetAllIssuesByProductNameVersionTest(bool resolved, string productName, string version, int expectedNumberOfIssues)
        {
            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByProductNameVersion")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("ProductName", productName)
                .WithSqlParam("Version", version)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckProductName(issues, productName));
            Assert.True(CheckProductVersion(issues, version));
        }
    }
}
