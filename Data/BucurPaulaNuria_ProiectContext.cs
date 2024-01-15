using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BucurPaulaNuria_Proiect.Models;

namespace BucurPaulaNuria_Proiect.Data
{
    public class BucurPaulaNuria_ProiectContext : DbContext
    {
        public BucurPaulaNuria_ProiectContext (DbContextOptions<BucurPaulaNuria_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<BucurPaulaNuria_Proiect.Models.Person> Person { get; set; } = default!;
        public DbSet<BucurPaulaNuria_Proiect.Models.Job> Job { get; set; } = default!;
    }
}
