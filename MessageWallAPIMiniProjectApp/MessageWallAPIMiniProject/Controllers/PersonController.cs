using MessageWallAPIMiniProject.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel data)
        {
            //_logger.LogInformation("Information about the person is {FirstName} {LastName}, is active - {IsActive}",
            //    data.Firstname, data.LastName, data.IsActive.ToString());
            _logger.LogInformation("The person was logged as {Person}", data);
        }
    }
}
