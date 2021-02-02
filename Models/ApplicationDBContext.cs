using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sample.BingMaps.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base ("DefaultConnection")
        {

        }

        public DbSet<Houses> Houses { get; set; }
    }
}