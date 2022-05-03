using System.Collections.Generic;
using WebApplication1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication1.ViewModel;
namespace WebApplication1.Repository
{
    public class CourseRepository : ICourseRepository
    {

        THECONTEXT db;
        public CourseRepository(THECONTEXT db)
        {
            this.db = db;
        }

        public List<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course FindById(int id)
        {
            return db.Courses.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(Course crs)
        {
            db.Courses.Add(crs);
            int raw = db.SaveChanges();
            return raw;
        }
        public int Edit(int id, Course c)
        {
            Course course = FindById(id);
            if (course != null)
            {
                course.Name = c.Name;
                course.degree = c.degree;
                course.dept_id = c.dept_id;
                course.minDegree = c.minDegree;
                int raw = db.SaveChanges();
                return raw;
            }
            return 0;
        }
        public int Delete(int id)
        {
            Course oldcrs = FindById(id);
            db.Courses.Remove(oldcrs);
            return db.SaveChanges();
        }

        public List<Course> GetCoursesByDeptId(int deptId)
        {
            return db.Courses.Where(c => c.dept_id == deptId).ToList();
        }

        public List<allcoursesVM> GetCoursesWithDept()
        {
            return db.Courses.Include(c => c.dept).
                    Select(c => new allcoursesVM()
                    {
                     Id = c.Id,
                     Name = c.Name,
                     degree = c.degree,
                     minDegree = c.minDegree,
                     dept_Name = c.dept.Name
                    }).ToList();
        }
    }
}
