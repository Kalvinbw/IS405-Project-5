using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models
{
    public class Supervisor
    {
        [Key]
        [Required]
        public int supervisorid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
