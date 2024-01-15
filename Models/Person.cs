using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BucurPaulaNuria_Proiect.Models
{
    public class Person
    {
        public int ID { get; set; }
        public required string Name {  get; set; }
        public required int Age { get; set; }

        [Display(Name="Hair color")]
        public required string HairColor {  get; set; }
        public required int Height { get; set; }
        
        public int JobID { get; set; }
        public Job Job { get; set; } //navigation property
    }
}
