using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace lab11Gregory.Controllers
{
    public class StudentsController
    {
        public string Enrolled(string filepath)
        {

            List<string> students =  DisplayStudentList(filepath);
            foreach (string stu in students)
            {
                return stu;
            }
            return $@"Here is a list of all the students enrolled at Codefellows. \n " +
                    "To return to Home page, go to url and type /Home \n" +
                    students;
        }
        static List<string> DisplayStudentList(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string[] names = File.ReadAllLines(filePath);
                List<string> namesList = new List<string>(names);
                return namesList;
            }
        }

        public string Faculty()
        {
            return ("Here is a list of the Faculty at Codefellows \n" +
                    "This list is currently empty, please check back later.  \n \n" +
                    "To retun to Home page, got to url and type /Home");
        }
    }
}
