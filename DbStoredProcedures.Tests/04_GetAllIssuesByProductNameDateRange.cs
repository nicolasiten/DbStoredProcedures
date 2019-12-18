using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByProductNameDateRange : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, "Day Trader Wannabe", 2019, 12, 11, 3, 2019, 12, 14, 10, 3)]
        [InlineData(false, "Social Anxiety Planner", 2019, 12, 10, 5, 2019, 12, 14, 10, 2)]
        public async Task GetAllIssuesByProductNameDateRangeTest(
            bool resolved,
            string productName,
            int yearFrom,
            int monthFrom,
            int dayFrom,
            int hourFrom,
            int yearTo,
            int monthTo,
            int dayTo,
            int hourTo,
            int expectedNumberOfIssues)
        {
            DateTime fromDate = new DateTime(yearFrom, monthFrom, dayFrom, hourFrom, 0, 0);
            DateTime toDate = new DateTime(yearTo, monthTo, dayTo, hourTo, 0, 0);

            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByProductNameDateRange")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("ProductName", productName)
                .WithSqlParam("DateFrom", fromDate)
                .WithSqlParam("DateTo", toDate)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckProductName(issues, productName));
        }
    }
}
