using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models.ViewModels
{
    public class StudentViewModel
    {
        public IQueryable<Student> Students { get; set; }
    }
}
