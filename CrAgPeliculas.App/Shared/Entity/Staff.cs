using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 

namespace CrAgPeliculas.App.Shared.Entity
{
    public class Staff : Person
    {
        [Required] public Role Role {get;set;}
        [Required] public string CityOfBirth {get;set;}
        [Required] public string ProfileImage {get;set;}
        [Required] public int KnowCredits {get;set;}
        [Required] public string Biography {get;set;}

        public List<StaffMovie> StaffMovie { get; set; } = new List<StaffMovie>();
    }

    public enum Role
    {
        Actor = 1,
        Director = 2,
        Producer = 3
    }
}