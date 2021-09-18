using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatJain2a7.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Title { get; set; }
        public decimal MaxSalary { get; set; }
        public decimal MinSalary { get; set; }
        public string SkillsNeeded { get; set; }
        public int MinExperienceRequired { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
