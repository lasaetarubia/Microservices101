using Microsoft.AspNetCore.Mvc;
using System;

namespace CommandsService.Controllers
{
    [Route("api/commands/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        public ActionResult TestInboundRequest()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound request ok from Platforms Controller");
        }
    }
}
