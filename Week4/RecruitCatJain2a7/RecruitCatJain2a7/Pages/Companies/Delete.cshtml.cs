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
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatJain2a7.Data.RecruitCatJain2a7Context _context;

        public DeleteModel(RecruitCatJain2a7.Data.RecruitCatJain2a7Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.IndustryAssociated).FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.FindAsync(id);

            if (Company != null)
            {
                _context.Company.Remove(Company);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
