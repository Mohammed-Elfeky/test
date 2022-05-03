using System.Collections.Generic;
using WebApplication1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        THECONTEXT db;
        public DepartmentRepository(THECONTEXT db)
        {
            this.db = db;
        }

        public List<Department> GetAll()
        {
            return db.Departments.ToList();
        }
        public Department FindById(int id)
        {
            return db.Departments.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(Department d)
        {
            db.Departments.Add(d);
            int raw = db.SaveChanges();
            return raw;
        }
        public int Edit(int id, Department d)
        {
            Department oldDept = FindById(id);
            if (oldDept != null)
            {
                oldDept.Name = d.Name;
                oldDept.Manager = d.Manager;
                int raw = db.SaveChanges();
                return raw;
            }
            return 0;
        }
        public int Delete(int id)
        {
            Department olddept = FindById(id);
            db.Departments.Remove(olddept);
            return db.SaveChanges();
        }
    }
}
