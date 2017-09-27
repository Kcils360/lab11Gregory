using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace lab11Gregory.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            return $@"" +
                "Welcome to Codefellows Student Portal. \n \n" +
                   "To register a new student, go to url and enter /Register \n \n" +
                   "For a list of Students, go to url and enter /Students/Enrolled \n \n" +
                   "For a list of Instructors, got to url and enter /Students/Faculty";
        }


        public string Faculty()
        {
            return ("Here is a list of the Faculty at Codefellows \n" +
                    "This list is currently empty, please check back later.  \n \n" +
                    "To retun to Home page, got to url and type /Home");
        }
    }

}

