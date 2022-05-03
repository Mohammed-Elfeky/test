using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using System.IO;
using WebApplication1.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System;

namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {
        IInstructorRepository _instructorRepository;
        ICourseRepository _courseRepository;
        IDepartmentRepository _departmentRepository;
        IWebHostEnvironment _WebHostEnvironment;


        public InstructorController(
        IInstructorRepository instructorRepository,
        ICourseRepository courseRepository, 
        IDepartmentRepository departmentRepository,
        IWebHostEnvironment WebHostEnvironment
            )
        {
            _instructorRepository = instructorRepository;
            _courseRepository = courseRepository;
            _departmentRepository = departmentRepository;
            _WebHostEnvironment=WebHostEnvironment;
    }


        
      

        public IActionResult getInstructors()
        {
            return View(_instructorRepository.GetAllWithDeptAndCourse());
        }

        public IActionResult getInstructor(int id)
        {
            return View(_instructorRepository.FindById(id));
        }
        

        public IActionResult AddIns()
        {
            return View(
                    new AddInsVM()
                    {
                        crss=_courseRepository.GetAll(),
                        depts=_departmentRepository.GetAll()
                    }
                );
        }

        public IActionResult SaveIns(AddInsVM ins)
        {
            if(
                ins.crs_id==null ||
                ins.salary==0 ||
                ins.image==null  ||
                ins.salary < 0 ||
                ins.dept_id == null
                )
            {
                return View("AddIns",ins) ;
            }
            else
            {


                string uploadsFolder = Path.Combine(_WebHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + ins.image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ins.image.CopyTo(fileStream);
                    fileStream.Close();
                }
                Instructor i=new Instructor()
                {
                    crs_id=ins.crs_id,
                    dept_id=ins.dept_id,
                    Name=ins.Name,
                    image= uniqueFileName,
                    salary=ins.salary,
                    address=ins.address,

                };
                _instructorRepository.Insert(i);
                return RedirectToAction("getInstructors");
            }
            
        }

        public IActionResult UpdateIns(int id)
        {

            return View(
                    "UpdateIns",
                    new AddInsVM()
                    {
                        crss = _courseRepository.GetAll(),
                        depts = _departmentRepository.GetAll()
                    }
                );
        }

        public IActionResult SaveUpdateIns(int id,AddInsVM ins)
        {


            if (
                ins.crs_id == null 
                || ins.salary == 0 ||
                ins.image==null || 
                ins.salary < 0 || 
                ins.dept_id == null
                )
            {
                //show view
                return View("UpdateIns",ins);
            }else{
                
                //System.IO.File.Copy(
                // @"C:\Users\Mohamed\Desktop\Men's Sweaters\" + ins.image,
                // @"F:\iti courses\mvc\Day2\lab\WebApplication1\WebApplication1\wwwroot\images\" + ins.image,
                // true
                //);
                //_instructorRepository.Edit(id, ins);
                return RedirectToAction("getInstructors");
            }
        }
    }
}
