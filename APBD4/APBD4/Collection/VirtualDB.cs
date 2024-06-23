namespace APBD4.Collection;

public  class VirtualDB
{
    
    public List<Animal> Animals { get; set; }
    public List<Visit> Visits { get; set; }

    public static VirtualDB Data { get; } = new VirtualDB();

    public VirtualDB()
    {
        Animals = new List<Animal>
            {
                new Animal { id = 1, imie = "Izzy", kategoria = "pies", masa = 15, kolor = "czarny" },
                new Animal { id = 2, imie = "Hesia", kategoria = "pies", masa = 17, kolor = "bialy" },
                new Animal { id = 3, imie = "Azgard", kategoria = "pies", masa = 13, kolor = "czarny" },
                new Animal { id = 4, imie = "Pudzian", kategoria = "kot", masa = 11, kolor = "szary" },
                new Animal { id = 5, imie = "Wader", kategoria = "krowa", masa = 130, kolor = "czarny" }
            };
        
        
        
        Visits = new List<Visit>
        {        

            new Visit { data = "2023-03-02", animal = Animals.FirstOrDefault(a => a.id == 2), opis = "zabieg", cena = 250.0 },
            new Visit { data = "2023-05-02", animal = Animals.FirstOrDefault(a => a.id == 2), opis = "zabieg", cena = 300.0 }
        };
    }
    
    

    

}