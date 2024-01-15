using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BucurPaulaNuria_Proiect.Data;
using BucurPaulaNuria_Proiect.Models;
using System.Security.Policy;

namespace BucurPaulaNuria_Proiect.Pages.Persons
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
            ViewData["JobID"] = new SelectList(_context.Set<Job>(), "ID", "Company");
            return Page();
        }

        [BindProperty]
        public Person Person { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ViewData["JobID"] = new SelectList(_context.Set<Job>(), "ID", "Company");

            _context.Person.Add(Person);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
