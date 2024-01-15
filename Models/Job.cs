using System.ComponentModel.DataAnnotations;

namespace BucurPaulaNuria_Proiect.Models
{
    public class Job
    {
        public int ID { get; set; }
        public required string Company { get; set; }
        public ICollection<Person> Persons { get; set; } //navigation property
    }
}
