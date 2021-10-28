using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrAgPeliculas.App.Shared.Entity
{
    public class Movie
    {
        public int Id {get;set;}
        [Required] public string Title {get;set;}
        [Required] public DateTime Year {get;set;}
        public string Backdrop { get; set; }
        [Required] public string Poster {get;set;}
        [Required] public string Overview { get; set; }
        [Required] public double Score {get;set;}
        [Required] public string Trailer {get;set;}

        public List<StaffMovie> StaffMovie { get; set; } = new List<StaffMovie>();
        public List<MovieCategory> MovieCategory { get; set; } = new List<MovieCategory>();
    }
}
