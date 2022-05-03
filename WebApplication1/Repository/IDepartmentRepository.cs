using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IDepartmentRepository
    {
        int Delete(int id);
        int Edit(int id, Department d);
        Department FindById(int id);
        List<Department> GetAll();
        int Insert(Department d);
    }
}