using Microsoft.AspNetCore.Mvc;
using training.gulf.services.entities;
using System.Collections.Generic;
using System.Linq;

namespace training.gulf.services.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MasterController : ControllerBase
{
    private readonly ILogger<MasterController> _logger;
    private readonly AZUREDBEBIDDINGDEVContext _context;

    public MasterController(ILogger<MasterController> logger, AZUREDBEBIDDINGDEVContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    [Route("[action]")]
    public ActionResult getCompanyAll()
    {
        var entity = _context.MstCompanies.ToList();
        return Ok(entity);
    }




}
