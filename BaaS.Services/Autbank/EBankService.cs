using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Repositories.Autbank.Interfaces;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Services.Autbank
{
    public class EBankService : IEBankService
    {

        private readonly IEBankRepository repositorio;

        public EBankService (IEBankRepository _repositorio)
        {
            repositorio = _repositorio;
        }

        public async Task<CadastrarContaResult> IncluirConta(ICadastrarContaSignature signature)
        {
            return await repositorio.IncluirConta(signature);
        }

        public async Task<ListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature)
        {
            return await repositorio.ListarModalidade(signature);
        }

        public async Task<IList<ListarModalidadeResult>> ListarModalidades()
        {
            return await repositorio.ListarModalidades();
        }
    }
}
