using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayersAPI.Data;
using PlayersAPI.Entities;
using PlayersAPI.Enums;

namespace PlayersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PlayerController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetAllPlayers()
        {
            List<Player> players = await _dataContext.Players.ToListAsync();
            return Ok(players);
        }
        
        [HttpGet("{nickame}")]

        public async Task<ActionResult<Player>> GetPlayer(string nickname)
        {
            Player? player = await _dataContext.Players.FindAsync(nickname);
            if (player is null)
                return NotFound("Hero not found");
            
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<List<Player>>> AddPlayer(Player player)
        {
             _dataContext.Players.Add(player);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Players.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Player>>> UpdatePlayer(Player updatedPlayer)
        {
            Player? Dbplayer = await _dataContext.Players.FindAsync(updatedPlayer.Nickname);
            if (Dbplayer is null)
                return NotFound("Hero not found");

            Dbplayer.Name = updatedPlayer.Name;
            Dbplayer.Email = updatedPlayer.Email;
            Dbplayer.Telefone = updatedPlayer.Telefone;
            Dbplayer.Group = updatedPlayer.Group;
            Dbplayer.Nickname = updatedPlayer.Nickname;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Players.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Player>>> DeletePlayer(string nickname)
        {
            Player? Dbplayer = await _dataContext.Players.FindAsync(nickname);
            if (Dbplayer is null)
                return NotFound("Hero not found");

           _dataContext.Players.Remove(Dbplayer);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Players.ToListAsync());
        }
    }
}
