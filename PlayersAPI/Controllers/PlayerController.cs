using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlayersAPI.Entities;
using PlayersAPI.Enums;

namespace PlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetAllPlayers()
        {
            List<Player> players = new List<Player>
            {
                new Player
                {
                    Name = "Ramon",
                    Email = "ramon@",
                    Telefone = 1199,
                    Nickname = "Kenai",
                    group = HeroGroup.Avengers
                }
            };
            return Ok(players);
        }
    }
}
