using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class MySqlDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public MySqlDbContext()
        {
            Database.EnsureDeleted();   
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=sliper98;persistsecurityinfo=True;database=new_schema;");
        }
    }
}
