using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class Company
    {
        [DisplayName("Company ID")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [StringLength(25, MinimumLength = 10, ErrorMessage = "Enter Valid Company Name")]
        public string Name { get; set; }

        [DisplayName("Position Name")]
        [Required(ErrorMessage = "Position Name is required")]
        [StringLength(14, MinimumLength = 2, ErrorMessage = "Enter Valid Position Name")]
        public string PositionName { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(80000, 150000, ErrorMessage = "Minimum Salary not in valid range")]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(180000, 350000, ErrorMessage = "Maximum Salary not in valid range")]
        public decimal MaximumSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [StringLength(14, MinimumLength = 10, ErrorMessage = "Enter Valid Location")]
        public string Location { get; set; }

        [DisplayName("Market Share")]
        [Range(10000, int.MaxValue , ErrorMessage = "Market Share not in valid range")]
        public decimal? MarketShare { get; set; }

        [DisplayName("Provide Sponsorship")]
        public bool ProvidesSponsorship { get; set; }

        public List<Candidate> Candidates { get; set; }

        [DisplayName("Industry Associated")]
        public Industry IndustryAssociated { get; set; }

        [DisplayName("Industry Linked")]
        public int IndustryAssociatedId { get; set; }

        [DisplayName("Company Email")]
        [Required(ErrorMessage = "Company Email is required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "Enter Valid Company Email")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Company URL")]
        [Required(ErrorMessage = "Company URL is required")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "Enter Valid Company URL")]
        [Url]
        public string CompanyUrl { get; set; }

        [DisplayName("Contact No.")]
        [Required(ErrorMessage = "Contact Number is required")]
        [StringLength(14, MinimumLength = 10, ErrorMessage = "Enter Valid Contact No.")]
        [Phone]
        public string ContactNumber { get; set; }
    }
}
