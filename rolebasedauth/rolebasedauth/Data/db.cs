using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rolebasedauth.Models;

namespace rolebasedauth.Data
{
    public class db : IdentityDbContext<User>
    {
        public db(DbContextOptions<db> options)
       : base(options)
        {
            
        }

        public DbSet<User> users { get; set; }
    }
}

