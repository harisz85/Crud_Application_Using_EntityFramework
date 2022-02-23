using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_B_DbFirst.App;
using Assignment_B_DbFirst.Controller;
using Assignment_B_DbFirst.RepositoryService;
using Assignment_B_DbFirst.Views;

namespace Assignment_B_DbFirst
{
    public class Program
    {
        static void Main(string[] args)
        {



            AssignmentDbFirst db = new AssignmentDbFirst();




            string input;


            do
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("choose the list you want to see");
                Console.WriteLine();

                Console.WriteLine($"{"Press 1 for Students"}\n" +
                    $"{"Press 2 for Courses"}\n" +
                    $"{"Press 3 for Trainers"}\n" +
                    $"{"Press 4 for Assignments"}\n" +
                    $"{"Press 5 for StudentsPerCourse"}\n" +
                    $"{"Press 6 for TrainersPerCourse"}\n" +
                    $"{"Press 7 for AssignmentsPerCourse"}\n" +
                    $"{"Press 8 for Assignments Per Course Per Student"}\n" +
                    $"{"Press 9 for students with more than one course"}\n" +
                    $"{"Press 10 to Create Student"}\n" +
                    $"{"Press 11 to Delete Student via Id"}\n" +
                    $"{"Press 12 to Search for Trainer via Id"}\n" +
                    $"{"Press 13 to Search For Assignment via Id"}\n" +
                    $"{"Press 14 to Search for Course by Type"}\n" +
                    $"{"Press 15 to Add aStudent to a Course"}\n" +
                    $"{"Press 16 to Remove a Student from a Course"}\n" +
                    $"{"Pres 17 to Add a Trainer to a Course"}\n" +
                    $"{"Press 18 to Remove a Trainer from a Course"}");



                input = Console.ReadLine();




                switch (input)

                {

                    case "1": ViewStudent.PrintStudents(db.Students.ToList(), "A list of Students"); break;
                    case "2":
                        ViewCourses.PrintCourses(db.Courses.ToList(), "A list of Courses"); break;
                    case "3":
                        ViewTrainer.PrintTrainers(db.Trainers.ToList(), "A list of Trainers"); break;
                    case "4": ViewAssignments.PrintAssignments(db.Assignments.ToList(), "A list of Assignmwnts"); break;
                    case "5": ViewCourses.PrintStudentPerCourse(db.Courses.ToList(), "A list of Students Per Course"); break;
                    case "6": ViewCourses.PrintTrainersPerCourse(db.Courses.ToList(), "A list of Trainers Per Course"); break;
                    case "7": ViewCourses.PrintAssignmentsPerCourse(db.Courses.ToList(), "A list of Assignments Per Course"); break;
                    case "8":
                        ViewStudent.PrintAssignmentsPerCoursePerStudent(db.Students.ToList(), "A list of Assignments Per Course Per Student"); break;
                    case "9": ViewStudent.PrintStudenstWithMoreThanOneCourse(db.Students.ToList(), " A list of students with more than one course"); break;
                    case "10": ViewStudent.CreateStudent(); break;
                    case "11": ViewStudent.DeleteStudent(); break;
                    case "12": ViewTrainer.ViewTrainersById(); break;
                    case "13": ViewAssignments.ViewAllAssignmentsById(); break;
                    case "14": ViewCourses.ViewCoursesByType(); break;
                    case "15": ViewCourses.AddStudentInCourse(); break;
                    case "16": ViewCourses.RemoveStudentFromCourse(); break;
                    case "17": ViewTrainer.AddTrainerToCourse(); break;
                    case "18": ViewTrainer.RemoveTrainerFromCourse(); break;
                 //   case "19": ViewStudent.RemoveAssignmentFromStudent();break;
                            


                }



            } while (input != "E" && input != "E");



        }







        //static void Print<T>(List<T> items)
        //{
        //    var props = typeof(T).GetProperties();


        //    foreach (var prop in props)
        //    {
        //        Console.Write("{0}\t", prop.Name);
        //    }
        //    Console.WriteLine();

        //    foreach (var item in items)
        //    {
        //        foreach (var prop in props)
        //        {
        //            Console.Write("{0}\t", prop.GetValue(item, null));
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
