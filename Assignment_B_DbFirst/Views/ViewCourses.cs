using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_B_DbFirst.RepositoryService;
using Assignment_B_DbFirst.Views;


namespace Assignment_B_DbFirst.Views
{
    public class ViewCourses
    {
        public static void PrintCourses(List<Course> courses, string message)
        {
            Console.WriteLine($"{message} \n");

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseID,-15}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.StartDate,-35}{course.EndDate,-35}");
            }
        }


        public static void PrintStudentPerCourse(List<Course> studentCourses, string message)
        {
            Console.WriteLine($"{message} \n");

            foreach (var course in studentCourses)
            {
                Console.WriteLine($"\n{course.Title,-15}{course.Type}\n");

                foreach (var student in course.Students)
                {
                    student.ViewAllStudents();
                }
            }
        }


        public static void PrintTrainersPerCourse(List<Course> trainersCourse,string message)
        {
          

            Console.WriteLine($"{message}, \n");

            foreach (var course in trainersCourse)
            {
                Console.WriteLine($"\n{course.Title,-15}{course.Type}");

                foreach (var trainer in course.Trainers)
                {
                    // Console.WriteLine($"\t\t {trainer.FirstName,-10}{trainer.LastName}");

                    trainer.ViewAllTrainers();
                }
            }
        }


        public static void PrintAssignmentsPerCourse(List<Course> assignmentsCourses,string message)
        {
            Console.WriteLine($"{message} \n");

            foreach (var course in assignmentsCourses)
            {
                Console.WriteLine($"\n{course.Title,-15}{course.Type}");

                foreach (var assignment in course.Assignments)
                {
                    assignment.ViewAllAssignments();


                }
            }
        }


        public static void ViewCoursesByType()
        {
          

            Console.WriteLine("Please enter the Type of the Courses you are lookng for ");

            Console.WriteLine("Press 1 for Full-Time");
            Console.WriteLine("Press 2 for Part-Time");

            string input = Console.ReadLine();
            Console.Clear();

            AssignmentDbFirst db = new AssignmentDbFirst();

            var fullTime = db.Courses.Where(x => x.Type == "Full-Time");
             var partTime = db.Courses.Where(x => x.Type == "Part-Time");

            switch (input)
            {
                case "1":
                    foreach (var course in fullTime)
                    {
                        Console.WriteLine($"{course.CourseID,-15}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.StartDate,-15}{course.EndDate}");
                    }
                    break;


                case "2":
                    foreach (var course in partTime)
                    {
                        Console.WriteLine($"{course.CourseID,-15}{course.Title,-15}{course.Stream,-15}{course.Type,-15}{course.StartDate,-25}{course.EndDate}");
                    }break;
            }

            
        }


       public static void AddStudentInCourse()
        {
            Console.WriteLine("Please input the id of the student you would like to add");

            int id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("please input the id of the course you would like to add the student in");


            int Courid = Int32.Parse(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();

           


          


            var student = db.Students.Find(id);

            var course = db.Courses.Find(Courid);

            course.Students.Add(student);

            db.SaveChanges();
           
        }



        public static void RemoveStudentFromCourse()
        {

            Console.WriteLine("Please input the id of the student you would like to remove");

            int id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("please input the id of the course you would like to remove the student from");


            int Courid = Int32.Parse(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();



            var student = db.Students.Find(id);

            var course = db.Courses.Find(Courid);

            course.Students.Remove(student);

            db.SaveChanges();
        }






    }
}
