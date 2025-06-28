using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChestsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Chest> Get([FromQuery] string? stage = null)
        {
            var all = ChestData.Chests.Values;
            if (string.IsNullOrEmpty(stage))
                return all;             // no filter: return everything
            return all.Where(c => c.Stage == stage);
        }
    }
}