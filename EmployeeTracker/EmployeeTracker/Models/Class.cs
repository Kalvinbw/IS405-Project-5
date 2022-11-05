using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models
{
    public class Class
    {
        [Key]
        [Required]
        public string classcode { get; set; }
        public string classname { get; set; }
    }
}
