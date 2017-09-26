using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11Gregory.Controllers
{
    public class StudentsController : Controller
    {
        public string Enrolled()
        {

            return ("Here is a list of all the students enrolled at Codefellows. \n \n" +
                    "To return to Home page, go to url and type /Home");
        }

        public string Faculty()
        {
            return ("Here is a list of the Faculty at Codefellows \n" +
                    "This list is currently empty, please check back later.  \n \n" +
                    "To retun to Home page, got to url and type /Home");
        }
    }
}
