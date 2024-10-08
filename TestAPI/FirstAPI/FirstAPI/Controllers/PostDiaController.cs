using FirstAPI.Comunication.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FirstAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class PostDiaController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PutDia([FromBody] RequestSobreRegiaoJson request)
    {
        var fusoGreeting = $"Que interessante, fuso horário {request.Fuso}... De qual região será?";
        return Ok(fusoGreeting);
    }
}
