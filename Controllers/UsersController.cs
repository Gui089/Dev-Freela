using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
  [Route("api/users")]
  public class UsersController : ControllerBase
  {

    [HttpGet]
    public IActionResult Get()
    {
      return Ok();
    }

    
  }
}
