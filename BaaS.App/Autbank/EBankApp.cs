using BaaS.App.Autbank.Interfaces;
using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Services.Autbank;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.App.Autbank
{
    public class EBankApp : IEBankApp
    {

        private readonly IEBankService eBankService;

        public EBankApp(IEBankService _eBankService)
        {
            eBankService = _eBankService;
        }

        public async Task<CadastrarContaResult> IncluirConta(ICadastrarContaSignature signature)
        {
            return await eBankService.IncluirConta(signature);
        }

        public async Task<ListarHistoricoContaResult> ListarHistorico(IListarHistoricoContaSignature signature)
        {
            return await eBankService.ListarHistorico(signature);
        }

        public async Task<IList<ListarHistoricoContaResult>> ListarHistoricos()
        {
            return await eBankService.ListarHistoricos();
        }

        public async Task<ListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature)
        {
            return await eBankService.ListarModalidade(signature);
        }

        public async Task<IList<ListarModalidadeResult>> ListarModalidades()
        {
            return await eBankService.ListarModalidades();
        }

        public async Task<ListarSaldoContarResult> ListarSaldoConta(IListarSaldoContaSignature signature)
        {
            return await eBankService.ListarSaldoConta(signature);
        }
    }
}
