using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Repositories.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Services.Autbank.Interfaces
{
    public interface IEBankService
    {
        Task<ListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature);
        Task<IList<ListarModalidadeResult>> ListarModalidades();
        Task<CadastrarContaResult> IncluirConta(ICadastrarContaSignature signature);
        Task<ListarSaldoContarResult> ListarSaldoConta(IListarSaldoContaSignature signature);

        Task<IList<ListarHistoricoContaResult>> ListarHistoricos();
        Task<ListarHistoricoContaResult> ListarHistorico(IListarHistoricoContaSignature signature);
    }
}
