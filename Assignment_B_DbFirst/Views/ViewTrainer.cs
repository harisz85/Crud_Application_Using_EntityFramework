using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B_DbFirst.Views
{
    public class ViewTrainer
    {
        public static void PrintTrainers(List<Trainer> trainers, string message)
        {
            Console.WriteLine($"{message}, \n");

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.TrainerID,-15}{trainer.FirstName,-15}{trainer.LastName,-15}{trainer.Subject,-15}");
            }
        }


        public static void ViewTrainersById()
        {


            Console.WriteLine("Please enter id of trainer you want to Find");
            int id = Convert.ToInt32(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();

           


            try
            {
                var trainer = db.Trainers.FirstOrDefault(x => x.TrainerID == id);

                Console.WriteLine($"Id : {trainer.TrainerID}  Firstname : {trainer.FirstName} : Lastname : {trainer.LastName} Subject : {trainer.Subject}");

                
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);


              
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid id");
            }
        }


        public static void AddTrainerToCourse()
        {
            Console.WriteLine("Please input the id of the Trainer you would like to add");

            int id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("please input the id of the course you would like to add the Trainer in");


            int Courid = Int32.Parse(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();


            var trainer = db.Trainers.Find(id);

            var course = db.Courses.Find(Courid);

            course.Trainers.Add(trainer);

            db.SaveChanges();
        }



        public static void RemoveTrainerFromCourse()
        {
            Console.WriteLine("Please input the id of the Trainer you would like to remove");

            int id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("please input the id of the course you would like to remove the Trainer from");


            int Courid = Int32.Parse(Console.ReadLine());

            AssignmentDbFirst db = new AssignmentDbFirst();


            var trainer = db.Trainers.Find(id);

            var course = db.Courses.Find(Courid);

            course.Trainers.Remove(trainer);

            db.SaveChanges();
        }
    }
}
