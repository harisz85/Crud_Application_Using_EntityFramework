using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B_DbFirst.Views
{
    public class ViewAssignments
    {
        public static void PrintAssignments(List<Assignment> assignments,string message)
        {
            Console.WriteLine($"{message} \n");

            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.AssignmentID,-15}{assignment.Title,-35}{assignment.Description,-50}{assignment.SubmitDate,-25}{assignment.OralMark,-5}{assignment.TotalMark,-15}{assignment.Type,-15}");
            }
        }


       public static void ViewAllAssignmentsById()
        {
            Console.WriteLine("Please enter id of the assignment you are lookng for");
            int id = Convert.ToInt32(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();

            var assignment = db.Assignments.FirstOrDefault(x => x.AssignmentID == id);

            Console.WriteLine($"{assignment.AssignmentID,-15}{assignment.Title,-35}{assignment.Description,-50}{assignment.SubmitDate,-25}{assignment.OralMark,-5}{assignment.TotalMark,-15}{assignment.Type,-15}");
        }
    }
}
