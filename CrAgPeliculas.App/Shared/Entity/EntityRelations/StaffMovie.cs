using System.Collections.Generic; 

namespace CrAgPeliculas.App.Shared.Entity
{
    public class StaffMovie
    {
        public int StaffId { get; set; }
        public int MovieId { get; set; }
        public Staff Staff { get; set; }
        public Movie Movie { get; set; }
        public string Director { get; set; }
    }
}