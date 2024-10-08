using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class GetDataController : ControllerBase
{
    [HttpGet("Hora")]
    public IActionResult GetHorarioBrasil()
    {
        var horarioBrasil = DateTime.Now.ToString("HH:mm:ss");
        return Ok(horarioBrasil);
    }
    [HttpGet("ApenasAno")]
    public IActionResult GetAnoAtual()
    {
        var anoAtual = DateTime.Now.Year;
        return Ok(anoAtual);
    }
}
