﻿using Microsoft.AspNetCore.Http;
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
    }
}
