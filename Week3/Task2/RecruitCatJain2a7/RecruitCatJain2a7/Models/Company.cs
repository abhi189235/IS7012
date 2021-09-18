using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateTime? StartDate { get; set; }
        public string Location { get; set; }
        public decimal? MarketShare { get; set; }
        public bool ProvidesSponsorship { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry IndustryAssociated { get; set; }
        public int IndustryAssociatedId { get; set; }
    }
}
