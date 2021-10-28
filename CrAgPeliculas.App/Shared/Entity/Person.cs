using System;
using System.ComponentModel.DataAnnotations;

namespace CrAgPeliculas.App.Shared.Entity
{
    public class Person
    {
        public int Id {get;set;}
        [Required] public string Name {get;set;}
        [Required] public string LastName {get;set;}
        [Required] public DateTime DateOfBirth {get;set;}
        [Required] public Gender Gender {get;set;}
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
        Other = 2
    }
}