using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B_DbFirst.RepositoryService
{
    public class AssignmentService
    {
        public AssignmentDbFirst db = new AssignmentDbFirst();

        public List<Assignment> GetAssignments()
        {
            return db.Assignments.ToList();
        }
    }
}
