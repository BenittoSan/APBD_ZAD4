using System.ComponentModel.DataAnnotations;

namespace APBD4.Collection;

public class Visit
{
    [Required]
    public String data { get; set; }
    
    [Required]
    public Animal animal { get; set; }
    
    public String opis { get; set; }
    
    public double cena { get; set; }
}