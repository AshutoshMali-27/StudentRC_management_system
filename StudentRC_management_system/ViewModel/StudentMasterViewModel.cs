﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRC_management_system.ViewModel
{
    public class StudentMasterViewModel
    {
        [Display(Name="Exam")]
        public int ExamId { get; set; }

        [Display(Name = "Subject")]
        public int SubjectId { get; set; }
        public IEnumerable<SelectListItem> ListOfExams { get; set; }
        public IEnumerable<SelectListItem> ListOfSubject { get; set; }

    }
}