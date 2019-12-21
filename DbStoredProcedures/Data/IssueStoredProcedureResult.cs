using System;
using System.Collections.Generic;
using System.Text;

namespace DbStoredProcedures.Data
{
    public class IssueStoredProcedureResult
    {
        public int IssueId { get; set; }

        public string Problem { get; set; }

        public DateTime CreationDate { get; set; }

        public string? Resolution { get; set; }

        public DateTime? ResolutionDate { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int OsId { get; set; }

        public string OsName { get; set; }

        public int VersionId { get; set; }

        public string Version { get; set; }

        public int IssueStatusId { get; set; }

        public string IssueStatusName { get; set; }
    }
}
