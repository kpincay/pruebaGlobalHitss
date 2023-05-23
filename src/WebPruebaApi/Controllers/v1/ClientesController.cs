using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Prueba.Application.Common.Wrappers;
using Prueba.Application.Features.Cliente.Commands.GetCliente;

namespace WebPruebaApi.Controllers.v1;

[ApiVersion("1.0")]

public class ClientesController : ApiControllerBase
{

    /// <summary>
    /// Obtener Cliente
    /// </summary>
    /// <param name="identificacion"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("GetCliente")]
    [EnableCors("AllowOrigin")]
    [ProducesResponseType(typeof(ResponseType<string>), StatusCodes.Status200OK)]
    [AllowAnonymous]
    public async Task<IActionResult> GetCliente(string identificacion, CancellationToken cancellationToken)
    {
        var objResult = await Mediator.Send(new GetClienteCommand(identificacion), cancellationToken);
        return Ok(objResult);
    }

}