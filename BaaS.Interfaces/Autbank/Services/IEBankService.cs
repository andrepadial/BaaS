using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Services
{
    public interface IEBankService
    {
        Task<IListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature);
        Task<IListarModalidadeResult> ListarModalidades();
        Task<ICadastrarContaResult> IncluirConta(ICadastrarContaSignature signature);
    }
}
