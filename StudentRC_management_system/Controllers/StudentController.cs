using StudentRC_management_system.Models;
using StudentRC_management_system.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRC_management_system.Controllers
{
    public class StudentController : Controller
    {
       // StudentsDBEntities objstudentsDBEntities;
        public StudentController()
        {
          //  objstudentsDBEntities = new StudentsDBEntities();
        }

        // GET: Student
        public ActionResult Index()
        {
           
            
            return View();
        }
    }
}