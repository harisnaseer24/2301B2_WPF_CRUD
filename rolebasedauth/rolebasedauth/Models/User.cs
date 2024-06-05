using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace rolebasedauth.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

    }
}
