using System.Collections.Generic;
using WebApplication1.Models;
using WebApplication1.ViewModel;
namespace WebApplication1.Repository
{
    public interface ICourseRepository
    {
        int Delete(int id);
        int Edit(int id, Course c);
        Course FindById(int id);
        List<Course> GetAll();
        int Insert(Course crs);
        List<Course> GetCoursesByDeptId(int deptId);
        List<allcoursesVM> GetCoursesWithDept();
    }
}