using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // NOTA mettendo controller tra quadre corrisponde a api/users (prende il nome della class senza Controller)
    public class BaseApiController : ControllerBase
    {
        //OSS. Non tutti i nostri Controller hanno bisogno del DBContext. Per questo motivo non si mette qui
    }
}