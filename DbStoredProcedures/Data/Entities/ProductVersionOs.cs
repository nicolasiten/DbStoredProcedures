using System;
using System.Collections.Generic;

namespace DbStoredProcedures.Data
{
    public partial class ProductVersionOs
    {
        public ProductVersionOs()
        {
            Issue = new HashSet<Issue>();
        }

        public int ProductFk { get; set; }
        public int VersionFk { get; set; }
        public int OperatingSystemFk { get; set; }

        public virtual OperatingSystem OperatingSystemFkNavigation { get; set; }
        public virtual Product ProductFkNavigation { get; set; }
        public virtual Version VersionFkNavigation { get; set; }
        public virtual ICollection<Issue> Issue { get; set; }
    }
}
