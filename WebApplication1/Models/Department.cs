using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }

        public virtual List<Instructor> inss { get; set; }
        public virtual List<Course> crss { get; set; }
        public virtual List<Trainee> tr { get; set; }

    }
}
