using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BucurPaulaNuria_Proiect.Data;
using BucurPaulaNuria_Proiect.Models;

namespace BucurPaulaNuria_Proiect.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly BucurPaulaNuria_Proiect.Data.BucurPaulaNuria_ProiectContext _context;

        public IndexModel(BucurPaulaNuria_Proiect.Data.BucurPaulaNuria_ProiectContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Person.Include(x => x.Job).ToListAsync();
        }
    }
}
