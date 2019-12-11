using System;
using System.Collections.Generic;

namespace DbStoredProcedures.Data
{
    public partial class Issue
    {
        public int Id { get; set; }
        public int StatusFk { get; set; }
        public int OperatingSystemFk { get; set; }
        public int ProductFk { get; set; }
        public int VersionFk { get; set; }
        public string Problem { get; set; }
        public DateTime CreationDate { get; set; }
        public string Resolution { get; set; }
        public DateTime? ResolutionDate { get; set; }

        public virtual ProductVersionOs ProductVersionOs { get; set; }
        public virtual IssueStatus StatusFkNavigation { get; set; }
    }
}
