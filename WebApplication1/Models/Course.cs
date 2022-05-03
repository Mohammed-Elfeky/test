using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MinLength(length: 3, ErrorMessage = "must be 3 letter or more")]
        [MaxLength(length: 25, ErrorMessage = "must be less than 25 letter")]
        [MyUnique()]
        public string Name { get; set; }
        [Required(ErrorMessage = "degree Required")]
        [Range(minimum: 50, maximum: 100, ErrorMessage = "degree must be between 50 ,100")]
        public decimal degree { get; set; }
        [Required(ErrorMessage = "minDegree Required")]
        [Remote("minLessThanDegree", "Course", ErrorMessage = "min degree must be less than degree"
            , AdditionalFields = "degree")]
        public decimal minDegree { get; set; }

        [ForeignKey("dept")]
        public int dept_id { get; set; }

        public virtual List<Instructor> Instructors { get; set; }
        public virtual Department dept { get; set; }
        public virtual List<crsReault> crsReaults { get; set; }
    }
}
