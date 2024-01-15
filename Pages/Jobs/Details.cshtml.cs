using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BucurPaulaNuria_Proiect.Data;
using BucurPaulaNuria_Proiect.Models;

namespace BucurPaulaNuria_Proiect.Pages.Jobs
{
    public class DetailsModel : PageModel
    {
        private readonly BucurPaulaNuria_Proiect.Data.BucurPaulaNuria_ProiectContext _context;

        public DetailsModel(BucurPaulaNuria_Proiect.Data.BucurPaulaNuria_ProiectContext context)
        {
            _context = context;
        }

        public Job Job { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FirstOrDefaultAsync(m => m.ID == id);
            if (job == null)
            {
                return NotFound();
            }
            else
            {
                Job = job;
            }
            return Page();
        }
    }
}
