using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Repository;
namespace WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepository courseRepository;
        IDepartmentRepository departmentRepository;
        public CourseController(
            ICourseRepository courseRepository,
            IDepartmentRepository departmentRepository
            )
        {
            this.courseRepository = courseRepository;
            this.departmentRepository = departmentRepository;

        }
        public IActionResult updateCourseAsPartial(int id)
        {
            ViewData["depts"] = departmentRepository.GetAll();
            return PartialView("updateCourse", courseRepository.FindById(id));
        }
        public IActionResult coursesAsJson(int id)
        {
            return Json(courseRepository.GetCoursesByDeptId(id));
        }
        public IActionResult minLessThanDegree(decimal minDegree, decimal degree)
        {
            
            if (minDegree < degree)
            {
                return Json(true);
            }
            else
                return Json(false);
        }
        public IActionResult AllCourses()
        {
            return View(courseRepository.GetCoursesWithDept());
        }

        public IActionResult AddCourse()
        {
            ViewData["depts"]=departmentRepository.GetAll();
            return View();
        }


        public IActionResult SaveCourse(Course c)
        {
            ViewData["depts"] = departmentRepository.GetAll();

            if (ModelState.IsValid==false)
            {
                return View("AddCourse",c);
            }
            else
            {
                courseRepository.Insert(c);
                return RedirectToAction("AllCourses");
            }
            
        }

        public IActionResult updateCourse(int id)
        {
            ViewData["depts"] = departmentRepository.GetAll();
            return View(courseRepository.FindById(id));
        }


        public IActionResult updateSaveCourse(int id,Course c)
        {
            ViewData["depts"] = departmentRepository.GetAll();

            if (ModelState.IsValid == false)
            {
                return View(
                    "updateCourse",
                    c
                    );
            }
            else
            {
                courseRepository.Edit(id, c);
                return RedirectToAction("AllCourses");
            }

        }

    }
}
