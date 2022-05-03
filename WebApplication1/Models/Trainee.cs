using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string image { get; set; }
        public string address { get; set; }
        public int grade { get; set; }
        [ForeignKey("dept")]
        public int dept_id { get; set; }

        public virtual Department dept { get; set; }
        public virtual List<crsReault> CrsReaults { get; set; }
    }
}
