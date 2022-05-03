using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class AppUser:IdentityUser
    {
        public string Address { get; set; }


        public List<Order> orders; 
    }
}
