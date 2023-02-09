namespace CdSite.Models
{

    public class Lending {

        public int Id {get; set;}

        public String? BorrowerName {get; set;} 

        public String? Date {get; set;}

        public int CdId {get ; set;}
        public Cd Cd {get; set;}  = default!;
    }
}