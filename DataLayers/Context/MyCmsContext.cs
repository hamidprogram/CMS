using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayers
{
    public class MyCmsContext:DbContext
    {
        public DbSet<PageGroup> pageGroups { get; set; }
        //---------------------------------------
        public DbSet<Page> Pages { get; set; }
        //---------------------------------------
        public DbSet<PageComment> PageComments { get; set; }
    }
}
