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




namespace Assignment_B_DbFirst.RepositoryService
{
    public class StudentService 
    {
        public AssignmentDbFirst db = new AssignmentDbFirst();


        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        


        public void AddStudent(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }
    }
}
