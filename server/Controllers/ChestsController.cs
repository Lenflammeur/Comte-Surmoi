using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChestsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Chest> Get([FromQuery] string stage)
        {
            // filter by stage so Angular can ask for the correct tier
            return ChestData.Chests.Values
                .Where(c => c.Stage == stage);
        }
    }


}