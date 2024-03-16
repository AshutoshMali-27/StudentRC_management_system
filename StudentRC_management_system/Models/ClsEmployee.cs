using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRC_management_system.Models
{
    public class ClsEmployee
    {
        public int id { get; set; }
         public string   code { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public  decimal Salary { get; set; }


        public IEnumerable<SelectListItem> ListOfStudents { get; set; }
    }
}