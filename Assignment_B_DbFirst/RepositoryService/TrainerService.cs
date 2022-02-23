using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B_DbFirst
{
   public class TrainerService
    {
        public AssignmentDbFirst db = new AssignmentDbFirst();

        public List<Trainer> GetStudents()
        {
            return db.Trainers.ToList();
        }
    }
}
