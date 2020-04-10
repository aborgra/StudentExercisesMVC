using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorViewModel
    {
        [Display(Name = "Instructor Id")]

        public int InstructorId { get; set; }
        [Display(Name = "First Name")]

        public string FirstName { get; set; }
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Display(Name = "Slack Handle")]

        public string SlackHandle { get; set; }
            public int CohortId { get; set; }
        [Display(Name = "Specialty")]

        public string Specialty { get; set; }
            public List<SelectListItem> CohortOptions { get; set; }
        
    }
}
