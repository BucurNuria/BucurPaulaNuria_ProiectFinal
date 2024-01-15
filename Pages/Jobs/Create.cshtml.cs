using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BucurPaulaNuria_Proiect.Data;
using BucurPaulaNuria_Proiect.Models;

namespace BucurPaulaNuria_Proiect.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        private readonly BucurPaulaNuria_Proiect.Data.BucurPaulaNuria_ProiectContext _context;

        public CreateModel(BucurPaulaNuria_Proiect.Data.BucurPaulaNuria_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Job Job { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            if(Job.Company != null) _context.Job.Add(Job);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
