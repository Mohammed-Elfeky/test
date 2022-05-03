using System.Collections.Generic;
using WebApplication1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        THECONTEXT db;
        public InstructorRepository(THECONTEXT db)
        {
            this.db = db;
        }

        public List<Instructor> GetAll()
        {
            return db.Instructors.ToList();
        }

        public Instructor FindById(int id)
        {
            return db.Instructors.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(Instructor std)
        {
            db.Instructors.Add(std);
            int raw = db.SaveChanges();
            return raw;
        }
        public int Edit(int id, Instructor ins)
        {
            Instructor oldIns = FindById(id);
            if (oldIns != null)
            {
                oldIns.Name = ins.Name;
                oldIns.image = ins.image;
                oldIns.salary = ins.salary;
                oldIns.address = ins.address;
                oldIns.crs_id = ins.crs_id;
                oldIns.dept_id = ins.dept_id;
                int raw = db.SaveChanges();
                return raw;
            }
            return 0;
        }
        public int Delete(int id)
        {
            Instructor oldStd = FindById(id);
            db.Instructors.Remove(oldStd);
            return db.SaveChanges();
        }



        public List<Instructor> GetAllWithDeptAndCourse()
        {
            return db.Instructors.
                            Include(i => i.crs).
                            Include(i => i.dept).
                            ToList();
        }
    }
}
