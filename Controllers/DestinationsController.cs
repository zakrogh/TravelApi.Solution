using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelApiContext _db;

    public DestinationsController(TravelApiContext db)
    {
      _db = db;
    }

    // GET api/destinations
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get(string name, string review, int rating, string user_name)
    {
        var query = _db.Destinations.AsQueryable();

        if (name != null)
        {
        query = query.Where(entry => entry.Name == name);
        }

        if (review != null)
        {
        query = query.Where(entry => entry.Review == review);
        }

        if (rating > 0)
        {
        query = query.Where(entry => entry.Rating == rating);
        }

        if (user_name != null)
        {
          query = query.Where(entry => entry.user_name == user_name);
        }

        return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Destination> Get(int id)
    {
        return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    }
    // PUT api/destinations/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Destination destination)
    {
        destination.DestinationId = id;
        _db.Entry(destination).State = EntityState.Modified;
        _db.SaveChanges();
    }
    // POST api/destinations
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }

    // DELETE api/destinations/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var destinationToDelete = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
      _db.Destinations.Remove(destinationToDelete);
      _db.SaveChanges();
    }
  }
}
