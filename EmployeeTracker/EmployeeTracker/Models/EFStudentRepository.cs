using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private StudentDBContext context { get; set; }
        public EFStudentRepository(StudentDBContext temp)
        {
            context = temp;
        }
        public IQueryable<Student> Students => context.Student;

        //IQueryable<Student> IStudentRepository.Students => throw new NotImplementedException();

        public void SaveStudent(Student s)
        {
            context.Update(s);
            context.SaveChanges();
        }

        public void CreateStudent(Student s)
        {
            context.Add(s);
            context.SaveChanges();
        }

        public void DeleteStudent(Student s)
        {
            context.Remove(s);
            context.SaveChanges();
        }
    }
}
