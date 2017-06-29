using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _ASP_MVC_Practice.Models;
using _ASP_MVC_Practice.EDMX;

namespace _ASP_MVC_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            CRUDExerciseEntities db = new CRUDExerciseEntities();


            Employee emp = new Employee();
            List<Employee> emptbl = new List<Employee>();

            try
            {
                var em = from e in db.tblEmployees
                         select e;


                if (em != null)
                {
                    foreach (var b in em)
                    {
                        Employee um = new Employee();
                        {
                            um.EmpId = b.EmpId;
                            um.Name = b.Name;
                        }
                        emptbl.Add(um);
                    }
                }
            }
            catch (Exception)
            {
                return Json(new { status = false, msg = "Something went wrong..." });
            }
            //return Json(new { status = true, msg = "Success", data = RenderPartialViewToString("_BrandIndex", emptbl) }, JsonRequestBehavior.AllowGet);
            return View(emptbl);
        }

        public ActionResult GetEmployeeList()
        {
            CRUDExerciseEntities db = new CRUDExerciseEntities();


            Employee emp = new Employee();
            List<Employee> emptbl = new List<Employee>();

            try
            {
                var em = from e in db.tblEmployees
                         select e;


                if (em != null)
                {
                    foreach (var b in em)
                    {
                        Employee um = new Employee();
                        {
                            um.EmpId = b.EmpId;
                            um.Name = b.Name;
                        }
                        emptbl.Add(um);
                    }
                }
            }
            catch (Exception)
            {
                return Json(new { status = false, msg = "Something went wrong..." });
            }
            //return Json(new { status = true, msg = "Success", data = RenderPartialViewToString("_BrandIndex", emptbl) }, JsonRequestBehavior.AllowGet);
            return View(emptbl);
        }

    }
}