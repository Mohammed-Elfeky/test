using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.ViewModel
{
    public class AddCourseVM
    {
        public Course crs { get; set; } 

        public List<Department> depts { get; set; }
    }
}
