using System;
using System.Collections.Generic;

namespace DbStoredProcedures.Data
{
    public partial class IssueStatus
    {
        public IssueStatus()
        {
            Issue = new HashSet<Issue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Issue> Issue { get; set; }
    }
}
