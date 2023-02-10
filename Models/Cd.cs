using System.ComponentModel.DataAnnotations;
namespace CdSite.Models {
    public class Cd {
        //Properties 
        public int Id { get; set;}

        
        [Required(ErrorMessage = "Obligatorisk")]
        [Display(Name = "Namn på album")]
        public string? Title  { get; set;}
        
        [Required(ErrorMessage = "Obligatorisk")]
        [Display(Name = "Aritstens namn")]
        public string? Artist { get; set;}

       [Required(ErrorMessage = "Obligatorisk")]
        [Display(Name = "Albuments genre")]
        public string? Genre { get; set;}

        [Required(ErrorMessage = "Obligatorisk")]
        [Display(Name = "Utgivningsår")]
        [RegularExpression("[0-9]+")]
        public String? Year { get; set;}

    }
}