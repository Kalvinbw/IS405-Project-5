using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTracker.Models
{
    public class Student
    {
        [Key]
        [Required]
        public string BYUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string International { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Expected_Hours_per_Week { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public string Phone { get; set; }
        public string PositionType { get; set; }
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public string EmplRecord { get; set; }
        public string Supervisor { get; set; }
        public string HireDate { get; set; }
        public string PayRate { get; set; }
        public string LastPayIncrease { get; set; }
        public string PayIncreaseAmount { get; set; }
        public string PayIncreaseDate { get; set; }
        public string YearInProgram { get; set; }
        public string PayGradTuition { get; set; }
        public string NameChangeCompleted { get; set; }
        public string Notes { get; set; }
        public string TerminatedYN { get; set; }
        public string TerminationDate { get; set; }
        public string QualtricsSurveySent { get; set; }
        public string SubmittedEForm { get; set; }
        public string EFormSubmissionDate { get; set; }
        public string AuthorizationtoWorkReceived { get; set; }
        public string AuthorizationtoWorkEmailSentDate { get; set; }
        public string BYUName { get; set; }
    }
}
