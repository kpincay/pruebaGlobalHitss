using MediatR;
using Prueba.Application.Common.Wrappers;
using Prueba.Application.Features.Cliente.Dto;
using Prueba.Application.Features.Cliente.Interfaces;

namespace Prueba.Application.Features.Cliente.Commands.GetCliente;

public record GetClienteCommand(string Identificacion) : IRequest<ResponseType<List<ClienteType>>>;

    public class GetClienteCommandHandler : IRequestHandler<GetClienteCommand, ResponseType<List<ClienteType>>>
    {
    private readonly IClienteService _repositoryAsync;

    public GetClienteCommandHandler(IClienteService repository)
    {
        _repositoryAsync = repository;
    }

    public async Task<ResponseType<List<ClienteType>>> Handle(GetClienteCommand objCommand, CancellationToken cancellationToken)
    {
        try
        {
            var objresult = await _repositoryAsync.GetCliente(objCommand.Identificacion, cancellationToken);
            return objresult;
        }
        catch (Exception)
        {

            throw;
        }
    }    
}


