using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Application.Features.Cliente.Dto
{
    public class ClienteType
    {
        public Guid Id { get; set; }
        public string RutaAcceso { get; set; } = string.Empty;

        public string NombreArchivo { get; set; } = string.Empty;
    }
}
