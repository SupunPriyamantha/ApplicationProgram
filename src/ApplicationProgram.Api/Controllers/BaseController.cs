using Microsoft.AspNetCore.Mvc;
using ApplicationProgram.Api.Models;

namespace ApplicationProgram.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class BaseController : Controller
    {
        protected ActionResult ToActionResult(BaseResponse response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
