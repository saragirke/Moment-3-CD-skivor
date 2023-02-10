using System.ComponentModel.DataAnnotations;

 
namespace CdSite.Models {
public class Artist {

public int Id {get; set;}

[Required(ErrorMessage = "Obligatorisk")]
[Display(Name="Namn på artist")]
public string? Name {get; set;}

 public ICollection<Cd>? Cds { get; set; }

}



}