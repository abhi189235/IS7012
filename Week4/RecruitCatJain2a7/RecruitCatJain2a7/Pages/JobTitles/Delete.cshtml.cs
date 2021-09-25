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
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatJain2a7.Data.RecruitCatJain2a7Context _context;

        public DeleteModel(RecruitCatJain2a7.Data.RecruitCatJain2a7Context context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.JobTitleId == id);

            if (JobTitle == null)
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

            JobTitle = await _context.JobTitle.FindAsync(id);

            if (JobTitle != null)
            {
                _context.JobTitle.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
