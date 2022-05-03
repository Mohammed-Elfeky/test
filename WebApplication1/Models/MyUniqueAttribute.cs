using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace WebApplication1.Models
{
    public class MyUniqueAttribute : ValidationAttribute
    {
       
        protected override ValidationResult IsValid(
            object value,
           ValidationContext validationContext
            )

        {
            THECONTEXT db = new THECONTEXT();
            
            var crs =validationContext.ObjectInstance as Course;


            if(crs.Id == 0)
            {
                string name = value.ToString();
                Course course =
                    db.Courses.FirstOrDefault(s => s.Name == name);
                if (course == null)
                {
                    return ValidationResult.Success;
                }
                else
                    return new ValidationResult("course Already Found");
            }
            else
            {
                Course crsfronDB = db.Courses.Find(crs.Id);
                if (crsfronDB.Name == crs.Name)
                {
                    return ValidationResult.Success;
                }
                else if (db.Courses.Any(c => c.Name == crs.Name))
                {
                    return new ValidationResult("course Already Found");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }


            return base.IsValid(value, validationContext);
        }
    }
}
