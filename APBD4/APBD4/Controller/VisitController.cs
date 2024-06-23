using System.Collections;
using APBD4.Collection;

using Microsoft.AspNetCore.Mvc;

namespace APBD4.Controller;


[Route("api/visit")]
[ApiController]
public class VisitController : ControllerBase
{

    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Visit>> GetVisits(int id)
    {

        var visitsAnimalWithId = new List<Visit>();

        foreach (var visit in VirtualDB.Data.Visits)
        {
            if(visit.animal.id==id)
                visitsAnimalWithId.Add(visit);
            
        }

        if (visitsAnimalWithId.Count == 0)
        {
            return NotFound($"Animal with id {id} do not have any visit");
        }
        
        return Ok(visitsAnimalWithId);

    }

    
    
    
    
    
    
}