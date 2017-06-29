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

            EmployeePractice emp = new EmployeePractice();
            tblEmployee emptbl = new tblEmployee();


            CRUDExerciseEntities db = new CRUDExerciseEntities();


            var em = from e in db.tblEmployees
                     select e;

            foreach (var data in em) {

            }
            emp.PCId = emptbl.EmpId;

            return View();

            
        }
    }
}