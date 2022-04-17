using Microsoft.AspNetCore.Mvc;
using Spacecraft.BusinessLayer.Commands;
using Spacecraft.BusinessLayer.Queries;

namespace SpaceShipStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpacecraftController : ControllerBase
    {
        private static readonly string[] Spacecrafts = new[]
        {
            "Tardis", "Serenity", "Enterprise", "Galactica", "Death Star"
        };


        private readonly ILogger<SpacecraftController> _logger;

        private readonly SpacecraftCommandHandler _commandHandler;
        private readonly SpacecraftQueryHandler _queryHandler;

        public SpacecraftController(ILogger<SpacecraftController> logger)
        {
            _logger = logger;
            _commandHandler = new SpacecraftCommandHandler();
        }

        [HttpGet(Name = "GetFeaturedSpaceCraft")]
       // [Route("Featured")]
        public IEnumerable<FeaturedSpacecraftDetails> GetFeatured()
        {
            // using query handler, get list of featured spacecrafts and show their details.
            return null;
        }
    }
}