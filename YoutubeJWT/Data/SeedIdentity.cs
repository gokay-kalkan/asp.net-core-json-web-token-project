using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeJWT.Models;

namespace YoutubeJWT.Data
{
    public class SeedIdentity
    {
        public static void Seed(UserManager<User> userManager)
        {
            

            var user = new User()
            {
                UserName = "JwtUser",
                Email = "jwtuser@gmail.com"
              

            };
            if (userManager.FindByNameAsync("JwtUser").Result == null)
            {

                var identityResult = userManager.CreateAsync(user, "jwt123456").Result;
            }
        }
    }
}
