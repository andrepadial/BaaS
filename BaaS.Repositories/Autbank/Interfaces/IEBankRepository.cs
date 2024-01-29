using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaaS.Repositories.Autbank.Interfaces
{
    public interface IEBankRepository
    {        
        Task<ListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature);
        Task<IList<ListarModalidadeResult>> ListarModalidades();
        Task<CadastrarContaResult> IncluirConta(ICadastrarContaSignature signature);

        Task<ListarSaldoContarResult> ListarSaldoConta(IListarSaldoContaSignature signature);
    }
}
