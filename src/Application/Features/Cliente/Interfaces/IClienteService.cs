using Prueba.Application.Common.Wrappers;
using Prueba.Application.Features.Cliente.Dto;
using Prueba.Domain.Entities;

namespace Prueba.Application.Features.Cliente.Interfaces
{
    public interface IClienteService
    {
        Task<ResponseType<List<ClienteType>>> GetCliente(string identificacion, CancellationToken cancellationToken);
    }
}

