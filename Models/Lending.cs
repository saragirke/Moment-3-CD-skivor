using System.ComponentModel.DataAnnotations;
namespace CdSite.Models
{

    public class Lending {

        public int Id {get; set;}
        
        [Required(ErrorMessage = "Obligatorisk")]
        [Display(Name = "Namn på lånare")]
        public String? BorrowerName {get; set;} 

        [Required(ErrorMessage = "Obligatorisk")]
        [Display(Name = "Datum för utlåning")]
        public DateTime Date {get; set;}


        [Display(Name = "Vilken CD ska lånas ut?")]
        public int? CdId {get ; set;}
        public Cd? Cd {get; set;}
    }
}