using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Interfaces.Autbank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.App.Autbank
{
    public class EBankApp : IEBankService
    {

        private readonly IEBankService eBankService;

        public EBankApp(IEBankService _eBankService)
        {
            eBankService = _eBankService;
        }

        public async Task<ICadastrarContaResult> IncluirConta(ICadastrarContaSignature signature)
        {
            return await eBankService.IncluirConta(signature);
        }

        public async Task<IListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature)
        {
            return await eBankService.ListarModalidade(signature);
        }

        public async Task<IListarModalidadeResult> ListarModalidades()
        {
            return await eBankService.ListarModalidades();
        }
    }
}
