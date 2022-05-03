using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string submitted { get; set; }   

        [ForeignKey("User")]
        public string User_id { get; set; }
        public AppUser User { get; set; }

    }
}
