using Microsoft.AspNetCore.Mvc;

namespace training.gulf.services.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Master2Controller : ControllerBase
{


    private readonly ILogger<Master2Controller> _logger;

    public Master2Controller(ILogger<Master2Controller> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("[action]")]
    public ActionResult GetCompanyByDatabase()
    {
        return Ok();
    }


}
