using Microsoft.AspNetCore.Mvc;
using Mapster;
using trainingSplitProject.gulf.model;
using trainingSplitProject.gulf.business.core;

namespace trainingSplitProject.gulf.services.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MasterController : ControllerBase
{


    private readonly ILogger<MasterController> _logger;
    private readonly IMasterLogic _masterLogic;

    public MasterController(ILogger<MasterController> logger, IMasterLogic masterLogic)
    {
        _logger = logger;
        _masterLogic = masterLogic;
    }

    [HttpGet]
    [Route("[action]")]
    public ActionResult GetCompanyByInterface()
    {
        var entity = _masterLogic.GetCompanyByDatabase();

        return Ok(entity);
    }


}
