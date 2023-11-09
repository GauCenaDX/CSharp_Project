using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPIHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        // GET: api/<MessageWallController>
        // Example: api/messagewall?firstName=John&lastName=Doe
        [HttpGet]
        public string Get(string? firstName = "", string? lastName = "")
        {
            string output = "";

            if (string.IsNullOrWhiteSpace(firstName) == true || string.IsNullOrWhiteSpace(lastName) == true)
            {
                output = $"Please provide firstName and lastName using the URL.";
            }
            else
            {
                output = $"Hi {firstName} {lastName}";
            }
            
            return output;
        }
    }
}
