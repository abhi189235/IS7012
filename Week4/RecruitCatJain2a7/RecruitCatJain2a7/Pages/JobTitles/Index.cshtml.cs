using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatJain2a7.Data;
using RecruitCatJain2a7.Models;

namespace RecruitCatJain2a7.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatJain2a7.Data.RecruitCatJain2a7Context _context;

        public IndexModel(RecruitCatJain2a7.Data.RecruitCatJain2a7Context context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
