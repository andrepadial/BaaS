using BaaS.App.Autbank.Interfaces;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.App.Autbank
{
    public class InfobankApp : IInfobankApp
    {
        private readonly IInfobankService infobankService;

        public InfobankApp (IInfobankService _infobankService)
        {
            infobankService = _infobankService;
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
