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
        public string Students()
        {


            return $@"Here is a list of all the students enrolled at Codefellows. \n " +
                    "To return to Home page, go to url and type /Home ";
        }

        public string Register(string name, int? grade)
        {
            if (!String.IsNullOrEmpty(name))
            {
                string filePath = "RegisteredStudents.txt";
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.Write(Environment.NewLine);
                    sw.WriteLine(name, grade);

                }
            }
            return ("\n \n To register, in URL type ?name=<name of student>&grade=<number of entering grade>\n \n" +
                    $"Student Name: {name}\n" +
                    $"Grade Regeistering for: {grade}");
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



    }
}
