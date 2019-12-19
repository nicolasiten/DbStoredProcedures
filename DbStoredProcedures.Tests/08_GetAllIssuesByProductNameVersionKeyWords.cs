using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByProductNameVersionKeyWords : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, "Day Trader Wannabe", "1.0", "makes", 1)]
        [InlineData(false, "Workout Planner", "1.1", "Premium,connection", 1)]
        public async Task GetAllIssuesByProductNameVersionKeyWordsTest(
            bool resolved,
            string productName,
            string version,
            string keyWords,
            int expectedNumberOfIssues)
        {
            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByProductNameVersionKeyWords")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("ProductName", productName)
                .WithSqlParam("Version", version)
                .WithSqlParam("KeyWords", keyWords)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckProductName(issues, productName));
            Assert.True(CheckProductVersion(issues, version));
            Assert.True(CheckKeyWords(issues, keyWords.Split(",")));
        }
    }
}
