using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnvApp.Models
{
    public class Db : IdentityDbContext<ApplicationUser>
    {
        public Db() : base("IdentityDb") { }

        public static Db Create()
        {
            return new Db();
        }
    }
}