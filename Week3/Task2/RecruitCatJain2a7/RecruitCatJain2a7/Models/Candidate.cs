using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string DomainSpecialization { get; set; }
        public DateTime? BirthDate { get; set; }
        public Company CompanyAssociated { get; set; }
        public int? CompanyAssociatedId { get; set; }
        public JobTitle JobTitleAssociated { get; set; }
        public int JobTitleAssociatedId { get; set; }
        public Industry IndustryAssociated { get; set; }
        public int IndustryAssociatedId { get; set; }
    }
}
