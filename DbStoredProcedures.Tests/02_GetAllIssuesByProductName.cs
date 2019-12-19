using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByProductName : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, "Workout Planner", 7)]
        [InlineData(false, "Investment Overlord", 2)]
        public async Task GetAllIssuesByProductNameTest(bool resolved, string productName, int expectedNumberOfIssues)
        {
            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByProductName")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("ProductName", productName)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckProductName(issues, productName));
        }
    }
}
