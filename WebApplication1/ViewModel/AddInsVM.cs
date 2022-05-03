using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class AddInsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile image { get; set; }
        public decimal salary { get; set; }
        public string address { get; set; }
        public int crs_id { get; set; }
        public int dept_id { get; set; }

        public List<Course> crss { get; set; }=new List<Course>();
        public List<Department> depts  { get; set; } = new List<Department>();

    }
}
