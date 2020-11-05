using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class MySqlDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";

            Role adminRole = new Role { ID = 1, RoleName = adminRoleName };
            Role userRole = new Role { ID = 2, RoleName = userRoleName };
            Person adminUser = new Person { ID = 1, FirstName = "admin", SecondName = "admin", Email = adminEmail, Password = adminPassword, RoleID = adminRole.ID };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<Person>().HasData(new Person[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
