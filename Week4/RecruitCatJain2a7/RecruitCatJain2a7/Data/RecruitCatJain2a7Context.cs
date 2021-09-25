using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatJain2a7.Models;

namespace RecruitCatJain2a7.Data
{
    public class RecruitCatJain2a7Context : DbContext
    {
        public RecruitCatJain2a7Context (DbContextOptions<RecruitCatJain2a7Context> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatJain2a7.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatJain2a7.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatJain2a7.Models.Company> Company { get; set; }

        public DbSet<RecruitCatJain2a7.Models.Candidate> Candidate { get; set; }
    }
}
