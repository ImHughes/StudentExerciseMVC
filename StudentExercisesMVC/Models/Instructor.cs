using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor
    {   [Required]
        
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }
        [Required]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; }
        [Required]
        [Display(Name = "Cohort Id")]
        public int CohortId { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
