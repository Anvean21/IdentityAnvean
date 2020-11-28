using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AnvApp.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<Db>
    {
        protected override void Seed(Db context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // создаем две роли
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };

            // добавляем роли в бд
            roleManager.Create(role1);
            roleManager.Create(role2);

            // создаем пользователей
            var admin = new ApplicationUser { Email = "evgeniy@gmail.com", UserName = "evgeniy@gmail.com", Nickname="Anvean", Year=2001 };
            string password = "Zeropopa_33";
            var result = userManager.Create(admin, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(admin.Id, role1.Name);
               // userManager.AddToRole(admin.Id, role2.Name);
            }

            base.Seed(context);
        }
    }
}