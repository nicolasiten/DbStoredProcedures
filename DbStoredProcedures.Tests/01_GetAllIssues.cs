using DbStoredProcedures.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DbStoredProcedures.Tests
{
    public class GetAllIssues : StoredProceduresTestBase
    {
        [Theory]
        [InlineData(true, 29)]
        [InlineData(false, 32)]
        public async Task GetAllIssuesTest(bool resolved, int expectedNumberOfIssues)
        {
            var issues = await IssueTrackerContext.LoadStoredProc("GetAllIssues")
                .WithSqlParam("Resolved", resolved)
                .ExecuteStoredProcAsync<IssueStoredProcedureResult>();

            Assert.Equal(expectedNumberOfIssues, issues.Count);

            Assert.True(CheckResolvedState(issues, resolved));
        }
    }
}
