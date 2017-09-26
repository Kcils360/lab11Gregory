using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11Gregory.Controllers
{
    [Route("Error")]

    public class ErrorController
    {
        [Route("Error")]

        public string Index()
        {
            return "Uh oh, something went wrong.";
        }
    }
}
