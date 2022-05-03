using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string image { get; set; }   
        public decimal salary { get; set; }
        public string address { get; set; }
        [ForeignKey("crs")]
        public int crs_id { get; set; }
        [ForeignKey("dept")]
        public int dept_id { get; set; }


        public virtual Course crs { get; set; }
        public virtual Department dept { get; set; }
        
    }
}
