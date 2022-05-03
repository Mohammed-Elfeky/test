using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IInstructorRepository
    {
        int Delete(int id);
        int Edit(int id, Instructor ins);
        Instructor FindById(int id);
        List<Instructor> GetAll();
        List<Instructor> GetAllWithDeptAndCourse();
        int Insert(Instructor std);
    }
}