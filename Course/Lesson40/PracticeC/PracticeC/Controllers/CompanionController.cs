using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   


public class CompanionContrller : ControllerBase
{
    private readonly ICompanionManager _companionManager;

    public CompanionContrller(ICompanionManager companionManager)
    {
        _companionManager = companionManager;
    }   

    [HttpGet("/api/carpool/getall")]
    public IActionResult GetAllCompanions()
    {      
        return Ok(_companionManager.GetCompanions());
    }

    [HttpGet("/api/carpool/search/{origin}&{destination}")]
    public List<Companion> SearchCarpool(string origin, string destination)
    {   
        return _companionManager.SearchCompanion(origin, destination);
    }

    [HttpPost("/api/carpool/add")]
    public IActionResult Create([FromBody] Companion companion)
    {
        _companionManager.AddCompanion(companion);
        return Ok("Попутчик успешно добавлен.");
    }

    [HttpDelete("/api/carpool/{id}")]
    public IActionResult Delete(int id)
    {  
        _companionManager.DeleteCompanion(id);
        return Ok("Попутчик удалён.");
    }
}