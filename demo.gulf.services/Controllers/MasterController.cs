using Microsoft.AspNetCore.Mvc;
using demo.gulf.business.core;
namespace demo.gulf.services.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MasterController : ControllerBase
{
    private readonly IMasterLogic _masterLogic;

    public MasterController(IMasterLogic masterLogic)
    {
        _masterLogic = masterLogic;
    }

    [HttpGet]
    [Route("[action]/{id}")]
    public ActionResult GetMstCompanyById(int id)
    {
        var result = _masterLogic.GetMstCompanyById(id);
        return Ok(result);
    }
    
}
