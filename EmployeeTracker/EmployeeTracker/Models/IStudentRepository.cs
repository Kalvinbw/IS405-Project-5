using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }

        public void SaveStudent(Student s);
        public void CreateStudent(Student s);
        public void DeleteStudent(Student s);
    }
}
