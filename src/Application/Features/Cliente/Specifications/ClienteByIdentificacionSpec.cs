using Ardalis.Specification;

namespace Prueba.Application.Features.Cliente.Specifications;

public class ClienteByIdentificacionSpec : Specification<Domain.Entities.Cliente>
{
    public ClienteByIdentificacionSpec(string Identificacion)
    {
        Query.Where(p => p.Identificacion.Contains(Identificacion));
           
    }
}
