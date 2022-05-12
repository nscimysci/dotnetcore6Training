using Microsoft.AspNetCore.Mvc;

namespace training.gulf.services.Controllers;

[ApiController]
[Route("api/[controller]")]
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
        var customerList = new List<string>() { "cust1", "cust2", "cust3", "cust4", "cust5" };

        customerList.Add("Cust6");
        customerList.Add("Cust7");
        customerList.AddRange(customerList);
        return customerList;
    }

    [HttpGet]
    [Route("[action]/{id}/{idCard}")]
    public ActionResult GetCustomersById(int id, string idCard)
    {
        return Ok(new { CustomerId = id, name = "Cust 1", idCard = idCard });
    }

    [HttpGet]
    [Route("[action]")]
    public ActionResult GetCustomersByQuery([FromQuery] int id, [FromQuery] string idCard)
    {
        return Ok(new { CustomerId = id, name = "Cust 1", idCard = idCard });
    }

    [HttpGet]
    [Route("[action]/{province}")]
    public ActionResult GetCustomersByQueryAndApi([FromQuery] int id, [FromQuery] string idCard, string province)
    {
        return Ok(new { CustomerId = id, name = "Cust 1", idCard = idCard, province = province });
    }

    [HttpPost]
    [Route("[action]")]
    public ActionResult AddCustomer(CustomerModel model)
    {
        return Ok(model);
    }

    [HttpPost]
    [Route("[action]")]
    public ActionResult AddCustomerByFromForm([FromForm] CustomerModel model)
    {
        return Ok(model);
    }

    [HttpPut]
    [Route("[action]/{id}")]
    public ActionResult UpdateCustomer(int id, CustomerModel model)
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




    public class CustomerModel
    {
        public int Id { get; set; }
        public int idCard { get; set; }
        public string name { get; set; }
        // public IFormFile FileByte { get; set; }

    }


}
