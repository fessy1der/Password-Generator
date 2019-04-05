using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClass
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=cn") { }

        public DbSet<Site> SiteList { get; set; }

    }
}
