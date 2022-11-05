using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models
{
    public class Position
    {
        [Key]
        [Required]
        public int positionid { get; set; }
        public string positionname { get; set; }
    }
}
