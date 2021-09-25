using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatJain2a7.Data;
using RecruitCatJain2a7.Models;

namespace RecruitCatJain2a7.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatJain2a7.Data.RecruitCatJain2a7Context _context;

        public CreateModel(RecruitCatJain2a7.Data.RecruitCatJain2a7Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyAssociatedId"] = new SelectList(_context.Company, "CompanyId", "Name");
        ViewData["IndustryAssociatedId"] = new SelectList(_context.Industry, "IndustryId", "IndustryName");
        ViewData["JobTitleAssociatedId"] = new SelectList(_context.JobTitle, "JobTitleId", "Title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
