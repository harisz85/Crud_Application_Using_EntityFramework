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
    public class ViewStudent
    {
        //public static void CreateStudent(Student student)
        //{
        //    AssignmentDbFirst db = new AssignmentDbFirst();
        //    db.Students.Add(student);
        //}

        public static void PrintStudents(List<Student> students, string message)
        {
            Console.WriteLine($"{message}\n");

            foreach (var stu in students)
            {
                Console.WriteLine($"{stu.StudentID,-15}{stu.FirstName,-15}{stu.LastName,-15}{stu.DateOfBirth,-25}{stu.TuitionFees,-15}");
            }

        }


        public static void PrintAssignmentsPerCoursePerStudent(List<Student> assignPerCoursePerStudents, string message)
        {
            Console.WriteLine($"{message} \n");

            foreach (var student in assignPerCoursePerStudents)
            {
                Console.WriteLine($"\n{student.FirstName,-15}{student.LastName}\n");

                foreach (var course in student.Courses)
                {

                    course.ViewAllCourses();

                    Console.WriteLine("\n");


                    foreach (var assignment in course.Assignments)
                    {

                        assignment.ViewAllAssignments();

                    }
                    Console.WriteLine("\t");
                }
            }

        }



        public static void PrintStudenstWithMoreThanOneCourse(List<Student> StudenstWithMoreThanOneCourse, string message)
        {

            Console.WriteLine($"{message}\n");

            foreach (var student in StudenstWithMoreThanOneCourse)
            {
                Console.WriteLine("{0}   {1}", student.FirstName, student.LastName);

                foreach (var course in student.Courses)
                {
                    if (student.Courses.Count > 1)
                    {

                        course.ViewAllCourses();
                    }
                }

            }
        }




        public static Student CreateStudent()
        {
            Console.WriteLine("Give Student's First Name : ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Give Student's Last Name : ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Give Student's Date of Birth");
            string input = Console.ReadLine();

            DateTime dateofbirth;
            DateTime.TryParse(input, out dateofbirth);

            Console.WriteLine("Give Students Tuition Fees (integer only)");
            int tuitionfees = Convert.ToInt32(Console.ReadLine());


            Student obj = new Student() { FirstName = firstname, LastName = lastname, DateOfBirth = dateofbirth, TuitionFees = tuitionfees };

            AssignmentDbFirst db = new AssignmentDbFirst();

            db.Students.Add(obj);
            db.SaveChanges();


            return obj;

        }




        public static void DeleteStudent()
        {
            Console.WriteLine("Please enter id of student you want to delete");
            int id = Convert.ToInt32(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();


            var student = db.Students.FirstOrDefault(x => x.StudentID == id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }


        }


        public static void RemoveAssignmentFromStudent()
        {
            Console.WriteLine("Please enter id of student you want to find");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the id of the Course from whiich you want to remove the assignment");

            int courseId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the id of the Assignment you want to remove");

            int assignId = Convert.ToInt32(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();

            var student = db.Students.Find(studentId);

            var course = db.Courses.Find(courseId);

            var assignment = db.Courses.Find(assignId);



            //db.Courses.Include(c => c.Assignments.Where(a => a.AssignmentID == assignId));
            //db.Students.Include(c => c.Courses.Where(x => x.CourseID == courseId));





          

          
           
            
              
        }


    }




}
