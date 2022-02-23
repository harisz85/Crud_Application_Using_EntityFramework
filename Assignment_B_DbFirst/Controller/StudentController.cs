using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_B_DbFirst.RepositoryService;
using Assignment_B_DbFirst.Views;

namespace Assignment_B_DbFirst.Controller
{
    public class StudentController
    {
        

        StudentService studentService = new StudentService();

        public void ReadAllStudents()
        {
            var allstudents = studentService.GetStudents();
            string message = "a list of all students";
            ViewStudent.PrintStudents(allstudents,message);
            
        }


        public void CreateStudent()
        {
            
            var student  = ViewStudent.CreateStudent();
              
        }


         


        public void DeleteStudent()
        {

        }

        

    }
}
