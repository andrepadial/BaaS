using BaaS.App.Autbank.Interfaces;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions;
using Microsoft.Extensions.Logging;

namespace BaaS.App.Autbank
{
    public class InfobankApp : IInfobankApp
    {
        private readonly IInfobankService infobankService;
        private readonly ILogger<InfobankApp> _logger;

        public InfobankApp (IInfobankService _infobankService, ILogger<InfobankApp> logger )
        {
            infobankService = _infobankService;
            _logger = logger;
        }

        public async Task<IList<ListarEnderecoClienteResult>> ListarEnderecos(IListarDadosClienteSignature signature)
        {
            return await infobankService.ListarEnderecos(signature);
        }

        public async Task<IList<ListarEstadosResult>> ListarEstados()
        {
            return await infobankService.ListarEstados();
        }
    }
}
