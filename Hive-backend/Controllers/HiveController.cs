using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Hive;
using Microsoft.AspNetCore.Mvc;

namespace Hive_backend.Controllers
{
    [Route("hive/")]
    [ApiController]
    public class HiveController : ControllerBase
    {
        [HttpGet("initialState")]
        public GameState Get()
        {
            var initialPieces = new List<ICreature>() {new QueenBee()};
            var players = new Collection<Player>() {new Player(initialPieces)};
            var game = new Game(players);
            
            return game.InitialState();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}