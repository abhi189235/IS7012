using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class Candidate
    {
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(14, MinimumLength = 2, ErrorMessage = "Enter Valid First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(14, MinimumLength = 2, ErrorMessage = "Enter Valid Last Name")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        [Range(80000,150000,ErrorMessage ="Target Salary not in valid range")]
        public decimal TargetSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DisplayName("Domain Specialization")]
        [Required(ErrorMessage = "Domain Specialization is required")]
        [StringLength(14, MinimumLength = 10, ErrorMessage = "Enter Valid Domain Specialization")]
        public string DomainSpecialization { get; set; }

        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Company Associated")]
        public Company CompanyAssociated { get; set; }

        [DisplayName("Company Linked")]
        public int? CompanyAssociatedId { get; set; }

        [DisplayName("Job Title Associated")]
        public JobTitle JobTitleAssociated { get; set; }

        [DisplayName("Job Title Linked")]
        public int JobTitleAssociatedId { get; set; }

        [DisplayName("Industry Associated")]
        public Industry IndustryAssociated { get; set; }

        [DisplayName("Industry Linked")]
        public int IndustryAssociatedId { get; set; }
    }
}
