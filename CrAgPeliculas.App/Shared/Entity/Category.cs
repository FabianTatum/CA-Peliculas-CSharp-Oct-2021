using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrAgPeliculas.App.Shared.Entity
{
    public class Category
    {
        public int Id {get;set;}
        [Required] public string Name {get;set;}

        public List<MovieCategory> MovieCategory { get; set; }
    }
}