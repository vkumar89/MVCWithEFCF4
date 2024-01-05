using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWithEFCF4.Models
{

    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("ConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolDbContext>());
        }
        public DbSet<Person> People { get; set; }
    }
}