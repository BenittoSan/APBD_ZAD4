using System.ComponentModel.DataAnnotations;

namespace APBD4.Collection;

public class Animal
{
   [Required]
    public int id { get; set; }
   
    
    public String imie { get; set; }
   
    public String kategoria { get; set; }
  
    public int masa { get; set; }
    
    public String kolor { get; set; }
}