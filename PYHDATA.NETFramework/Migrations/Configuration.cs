using PYHDATA.NETFramework.Models;
using PYHDATA.NETFramework.Util;
using PYHDATA.NETFramework.Util.Common;
using System;
using System.Data.Entity.Migrations;
namespace PYHDATA.NETFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // SeedData User
            User user = new User(){
                FirstName = "MS",
                LastName = "Sen",
                BirthDate = "01/01/1999",
                Email = "admin@gmail.com",
                Phone = "0987654321",
                Address = "Hà Nội",
                Image = "Default.png",
                Password = Helper.SHA128("123456"),
                Role = ERole.Admin,
                Status = EStatus.Active,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            context.Users.AddOrUpdate(user);
            context.SaveChanges();
        }
    }
}
