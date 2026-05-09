using Microsoft.AspNetCore.Mvc;

/*
Template for route parameter and api controller
*/
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
