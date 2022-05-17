using Microsoft.AspNetCore.Mvc;

namespace demo.gulf.services.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{

    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("[action]")]
    public ActionResult<List<string>> GetCustomers()
    {
        var customerList = new List<string>(){"natapon", "bb", "ee", "ii" };
        return customerList;
    }

    [HttpGet]
    [Route("[action]/{id}/{idCard}")]
    public IActionResult GetCustomersById(int id,string idCard)
    {
        return Ok(new {CustomerId = id, name = "natapon", idCard = idCard});
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult GetCustomersByQuery([FromQuery] int id,[FromQuery] string idCard)
    {
        return Ok(new { CustomerId = id, name = "natapon", idCard = idCard });
    }

    [HttpPost]
    [Route("[action]")]
    public ActionResult AddCustomer(Customer model)
    {
        return Ok(model);
    }

    [HttpPost]
    [Route("[action]")]
    public ActionResult AddCustomerByFormForm([FromForm] Customer model)
    {
        return Ok(model);
    }


    [HttpPut]
    [Route("[action]/{id}")]
    public ActionResult UpdateCustomerById(int id, [FromBody] Customer model)
    {

        if (id != model.Id)
        {
            return BadRequest();
        }

        if (id != 5551234)
        {
            return NotFound();
        }

        return Ok(model);
    }

    [HttpDelete]
    [Route("[action]/{id}")]
    public ActionResult DeleteCustomerById(int id)
    {
        if (id != 5551234)
        {
            return NotFound();
        }
        return NoContent();
    }


    public class Customer
    {
        public int Id { get; set; }
        public int idCard { get; set; }
        public string name { get; set; }
    }

}
