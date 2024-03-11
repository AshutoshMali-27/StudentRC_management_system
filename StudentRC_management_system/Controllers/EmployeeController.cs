using StudentRC_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRC_management_system.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(ClsEmployee objemployee)
        {
            ClsEmployeeDbcontext context = new ClsEmployeeDbcontext();

           

            ClsEmployee obj = new ClsEmployee();
            obj.code = objemployee.code;
            obj.Name = objemployee.Name;
            obj.Age = objemployee.Age;
            obj.Department = objemployee.Department;
            obj.Email = objemployee.Email;
            obj.Salary = objemployee.Salary;
            

            context.AddEmployee(obj);
            ModelState.Clear();

            return Json( new { successMessage="Data successfully added."},JsonRequestBehavior.AllowGet);
        }
    }
}