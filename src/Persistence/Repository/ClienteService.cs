using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Prueba.Application.Common.Exceptions;
using Prueba.Application.Common.Interfaces;
using Prueba.Application.Common.Wrappers;
using Prueba.Application.Features.Cliente.Dto;
using Prueba.Application.Features.Cliente.Interfaces;
using Prueba.Application.Features.Cliente.Specifications;
using Prueba.Domain.Entities;

namespace Prueba.Persistence.Repository
{
    public class ClienteService : IClienteService
    {
        private const string _User = "admin";
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly ILogger<Cliente> _log;
        private readonly IRepositoryAsync<Cliente> _repoAjuntoAsync;

        public ClienteService(IConfiguration config, IRepositoryAsync<Cliente> repository, IMapper mapper, ILogger<Cliente> log)
        {
            _repoAjuntoAsync = repository;
            _mapper = mapper;
            _config = config;
            _log = log;
        }



        #region GetCliente

        public async Task<ResponseType<List<ClienteType>>> GetCliente(string identificacion, CancellationToken cancellationToken)
        {
            try
            {
                var Cliente_ = await _repoAjuntoAsync.ListAsync(new ClienteByIdentificacionSpec(identificacion), cancellationToken);
                
                if (Cliente_.Any())
                {
                    return await Task.FromResult(new ResponseType<List<ClienteType>>() { Succeeded = true, Message = CodeMessageResponse.GetMessageByCode("000"), StatusCode = "000", Data = _mapper.Map<List<ClienteType>>(Cliente_) });
                }
                
                return await Task.FromResult(new ResponseType<List<ClienteType>>() { Succeeded = true, Message = CodeMessageResponse.GetMessageByCode("001"), StatusCode = "001" });
            }
            catch (Exception ex)
            {
                _log.LogError(ex, string.Empty);
                return new ResponseType<List<ClienteType>>() { Succeeded = false, Message = CodeMessageResponse.GetMessageByCode("002"), StatusCode = "002" };
            }
        }

        #endregion


    }
}