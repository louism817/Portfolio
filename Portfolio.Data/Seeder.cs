using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Portfilio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext db)
        {
            // Create roles, and an admin
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(db);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(db);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);


            if (!roleManager.RoleExists("Admin"))
            {
                var result = roleManager.Create(new Role
                {
                    Name = "Admin"
                });
            }
             
            ApplicationUser louis = userManager.FindByName("louism817@gmail.com");

            if (louis == null)
            {
                louis = new ApplicationUser
                {
                    Email = "louism817@gmail.com",
                    UserName = "louism817@gmail.com" 
                };

                userManager.Create(louis, "Lmurphy1!");
                userManager.AddToRole(louis.Id, "Admin");

                louis = userManager.FindByName("louism817@gmail.com");
            }
        }
    }
}
