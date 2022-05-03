using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.ViewModel;
namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        THECONTEXT db = new THECONTEXT();

        public IActionResult getAllGrades(int id)
        {
            List<getAllGrades> data=db.GetCrsReaults.
                Include(gc=>gc.Crs)
                .Include(gc=>gc.tr).
                Where(gc=>gc.tr_id==id)
                .Select(
                gc => new getAllGrades {
                    name=gc.tr.Name,
                    subject=gc.Crs.Name,
                    grade=gc.degree,
                    color=gc.Crs.minDegree < gc.degree ? "green":"red",
                    status = gc.Crs.minDegree < gc.degree ? "pass" : "fail"
                }
                ).ToList();

            return View(data);
        }

        public IActionResult getGrade(int id)
        {
            getAllGrades data = db.GetCrsReaults.
                Include(gc => gc.Crs)
                .Include(gc => gc.tr).
                Where(gc => gc.tr_id == id && gc.crs_id==2)
                .Select(
                gc => new getAllGrades
                {
                    name = gc.tr.Name,
                    subject = gc.Crs.Name,
                    grade = gc.degree,
                    color = gc.Crs.minDegree < gc.degree ? "green" : "red",
                    status= gc.Crs.minDegree < gc.degree ? "pass" : "fail"
                }
                ).Single();

            return View(data);
        }
    }
}
