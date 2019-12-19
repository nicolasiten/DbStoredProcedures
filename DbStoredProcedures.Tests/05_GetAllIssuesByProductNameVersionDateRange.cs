using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByProductNameVersionDateRange : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, "Investment Overlord", "1.0", 2019, 12, 8, 3, 2019, 12, 14, 10, 1)]
        [InlineData(false, "Social Anxiety Planner", "1.1", 2019, 12, 5, 5, 2019, 12, 14, 10, 2)]
        public async Task GetAllIssuesByProductNameVersionDateRangeTest(
            bool resolved,
            string productName,
            string version,
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

            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByProductNameVersionDateRange")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("ProductName", productName)
                .WithSqlParam("Version", version)
                .WithSqlParam("DateFrom", fromDate)
                .WithSqlParam("DateTo", toDate)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckProductName(issues, productName));
            Assert.True(CheckProductVersion(issues, version));
            Assert.True(CheckProductDateRange(issues, fromDate, toDate));
        }
    }
}
