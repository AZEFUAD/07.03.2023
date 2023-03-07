using Core.Entities;
using Core.Helpers;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DbInitializer
    {
        static int id;
        public static void SeedAdmins()
        {
            var admins = new List<Admin>
            {
                new Admin
                {
                    Id = ++id,
                    Username = "admin01",
                    Password = PasswordHasher.Encrypt("244844"),
                    CreatedBy = "Created by System"
                },
                new Admin
                {
                    Id = ++id,
                    Username = "admin02",
                    Password = PasswordHasher.Encrypt("367298"),
                    CreatedBy = "Created by System"
                },
                new Admin
                {
                    Id = ++id,
                    Username = "admin03",
                    Password = PasswordHasher.Encrypt("145678"),
                    CreatedBy = "Created by System"
                }
            };
            DbContext.Admins.AddRange(admins);
        }
    }
}
