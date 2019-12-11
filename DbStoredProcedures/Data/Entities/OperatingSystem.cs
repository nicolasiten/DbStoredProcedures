using System;
using System.Collections.Generic;

namespace DbStoredProcedures.Data
{
    public partial class OperatingSystem
    {
        public OperatingSystem()
        {
            ProductVersionOs = new HashSet<ProductVersionOs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductVersionOs> ProductVersionOs { get; set; }
    }
}
