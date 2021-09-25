using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Enter valid Title")]
        public string Title { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(100000, 250000, ErrorMessage = "Maximum Salary not in valid range")]
        public decimal MaxSalary { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(80000, 150000, ErrorMessage = "Minimum Salary not in valid range")]
        public decimal MinSalary { get; set; }

        [DisplayName("Skills Needed")]
        [Required(ErrorMessage = "Skills Needed required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Enter Skills Needed")]
        public string SkillsNeeded { get; set; }

        [DisplayName("Minimum Experience Required")]
        [Range(0, 60, ErrorMessage = "Minimum Experience not in valid range")]
        public int MinExperienceRequired { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
