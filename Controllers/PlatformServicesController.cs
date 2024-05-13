using Microsoft.AspNetCore.Mvc;

namespace CommandService;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformServicesController : ControllerBase
{
    public PlatformServicesController()
    {

    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("--> Inbound POST command.");
        return Ok("--> Inbound connection is working just fine.");
    }
}
