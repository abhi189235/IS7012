using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatJain2a7.Data;
using RecruitCatJain2a7.Models;

namespace RecruitCatJain2a7.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatJain2a7.Data.RecruitCatJain2a7Context _context;

        public IndexModel(RecruitCatJain2a7.Data.RecruitCatJain2a7Context context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.CompanyAssociated)
                .Include(c => c.IndustryAssociated)
                .Include(c => c.JobTitleAssociated).ToListAsync();
        }
    }
}
