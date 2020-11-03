using Microsoft.AspNetCore.Mvc;

namespace ItLank.CleanArchitecture.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
