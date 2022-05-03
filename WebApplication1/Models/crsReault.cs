using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class crsReault
    {
        public int Id { get; set; }
        public decimal degree { get; set; }

        [ForeignKey("Crs")]
        public int crs_id { get; set; }
        [ForeignKey("tr")]
        public int tr_id { get; set; }

        public virtual Course Crs { get; set; }
        public virtual Trainee tr { get; set; }
    }
}
