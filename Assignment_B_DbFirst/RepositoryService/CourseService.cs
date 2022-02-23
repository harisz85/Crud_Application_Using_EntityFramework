using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_B_DbFirst.RepositoryService
{
    public class CourseService
    {

        public AssignmentDbFirst db = new AssignmentDbFirst();

        public List<Course> GetStudents()
        {
            return db.Courses.ToList();
        }
    }
}
