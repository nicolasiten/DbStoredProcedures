using DbStoredProcedures.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssuesByKeyWords : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, "makes,application", 8)]
        [InlineData(false, "subscriber,social", 3)]
        public async Task GetAllIssuesByKeyWordsTest(
            bool resolved,
            string keyWords,
            int expectedNumberOfIssues)
        {
            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssuesByKeyWords")
                .WithSqlParam("Resolved", resolved)
                .WithSqlParam("KeyWords", keyWords)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
            Assert.True(CheckKeyWords(issues, keyWords.Split(",")));
        }
    }
}
