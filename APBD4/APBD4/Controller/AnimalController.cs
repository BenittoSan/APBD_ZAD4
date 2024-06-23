using APBD4.Collection;
using Microsoft.AspNetCore.Mvc;

namespace APBD4.Controller;

[Route("api/animal")]
public class AnimalController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateAnimal([FromBody] Animal animal)
    {

        if (VirtualDB.Data.Animals.Any(a => a.id == animal.id))
        {
            return Ok($"Animal with {animal.id} allready exists");
        }
        
        VirtualDB.Data.Animals.Add(animal);
        return Ok(StatusCode(StatusCodes.Status201Created));
    }

    [HttpPut]
    public IActionResult UpdateAnimal([FromBody]Animal animal)
    {
        var animalToUpdate = VirtualDB.Data.Animals.FirstOrDefault(a => a.id == animal.id);

        if (animalToUpdate == null)
        {
            return BadRequest($"Animal with {animal.id} do not exists");
        }

        animalToUpdate.id = animal.id;
        animalToUpdate.imie = animal.imie;
        animalToUpdate.kategoria = animal.kategoria;
        animalToUpdate.masa = animal.masa;
        animalToUpdate.kolor = animal.kolor;

        return Ok(StatusCodes.Status204NoContent);

    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = VirtualDB.Data.Animals.FirstOrDefault(a => a.id == id);

        if (animalToDelete == null)
        {
            return BadRequest($"Animal with {id} do not exists ");
        }

      var affectedRows =  VirtualDB.Data.Visits.Count(v => v.animal.id == id);
        
        VirtualDB.Data.Animals.Remove(animalToDelete);
        
        VirtualDB.Data.Visits.RemoveAll(a => a.animal.id == id);
        
        


        return Ok($"row affected {affectedRows}");

    }
    
}