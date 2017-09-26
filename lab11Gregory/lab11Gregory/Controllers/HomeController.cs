using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11Gregory.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to Codefellows Student Portal. \n \n" +
                   "To register a new student, go to url and enter /Register \n \n" +
                   "For a list of Students, go to url and enter /Students/Enrolled \n \n" +
                   "For a list of Instructors, got to url and enter /Students/Faculty";
        }
        public string Register(string name, int grade)
        {

            return ("\n \n To register, in URL type ?name=<name of student>&grade=<number of entering grade>\n \n" +
                    $"Student Name: {name}\n" +
                    $"Grade Regeistering for: {grade}");
        }
    }

}

