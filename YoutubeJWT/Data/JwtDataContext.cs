using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeJWT.Models;

namespace YoutubeJWT.Data
{
    public class JwtDataContext:IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U1FS87R\SQLEXPRESS; Database=JwtIdentityDb; integrated security=true;");
        }
        public DbSet<User> User{ get; set; }

    }
}
