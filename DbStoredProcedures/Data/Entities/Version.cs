﻿using System;
using System.Collections.Generic;

namespace DbStoredProcedures.Data
{
    public partial class Version
    {
        public Version()
        {
            ProductVersionOs = new HashSet<ProductVersionOs>();
        }

        public int Id { get; set; }
        public string VersionName { get; set; }

        public virtual ICollection<ProductVersionOs> ProductVersionOs { get; set; }
    }
}
