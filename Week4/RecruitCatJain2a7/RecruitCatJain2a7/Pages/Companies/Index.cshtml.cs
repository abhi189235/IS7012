using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatJain2a7.Data;
using RecruitCatJain2a7.Models;

namespace RecruitCatJain2a7.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatJain2a7.Data.RecruitCatJain2a7Context _context;

        public IndexModel(RecruitCatJain2a7.Data.RecruitCatJain2a7Context context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.IndustryAssociated).ToListAsync();
        }
    }
}
