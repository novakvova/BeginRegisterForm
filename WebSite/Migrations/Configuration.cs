namespace WebSite.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebSite.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            #region InitRolesUser

            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole
            {
                //Id = Guid.NewGuid().ToString(),
                Name="Admin"
            });

            #endregion

            //context.Users.AddOrUpdate(x => x.Email, new IdentityUser
            //{
            //    //Id = Guid.NewGuid().ToString(),
            //    Email = "Admin"
            //});


            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
