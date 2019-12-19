using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByProductNameKeyWords : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, "Investment Overlord", "makes,application", 2)]
        [InlineData(false, "Workout Planner", "Premium,connection", 1)]
        public async Task GetAllIssuesByProductNameKeyWordsTest(
            bool resolved, 
            string productName, 
            string keyWords, 
            int expectedNumberOfIssues)
        {
            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByProductNameKeyWords")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("ProductName", productName)
                .WithSqlParam("KeyWords", keyWords)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckProductName(issues, productName));
            Assert.True(CheckKeyWords(issues, keyWords.Split(",")));
        }
    }
}
