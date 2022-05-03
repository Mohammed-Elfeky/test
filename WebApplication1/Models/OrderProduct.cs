using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class OrderProduct
    {
        [ForeignKey("order")]
        public int o_id { get; set; }

        [ForeignKey("product")]
        public int p_id { get; set; }
        public int quantity { get; set; }


        public Order order { get; set; }
        public Product product { get; set; }

    }

}
