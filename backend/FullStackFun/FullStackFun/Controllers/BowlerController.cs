using Mission10_Erickson.Data;
using Microsoft.AspNetCore.Mvc;

namespace Mission10_Erickson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly BowlerDbContext _context;

        public BowlerController(BowlerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var bowlersWithTeams = from b in _context.Bowlers
                                   join t in _context.Teams on b.TeamID equals t.TeamID
                                   where t.TeamName == "Marlins" || t.TeamName == "Sharks"
                                   select new
                                   {
                                       b.BowlerId,
                                       b.FirstName,
                                       b.MiddleInit,
                                       b.LastName,
                                       b.Address, // This should now match the column correctly
                                       b.City,
                                       b.State,
                                       b.Zip,
                                       b.PhoneNumber,
                                       TeamName = t.TeamName // Get the correct team name
                                   };

            return Ok(bowlersWithTeams.ToList());
        }
    }
}
