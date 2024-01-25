using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Interfaces.Autbank.Repositories;
using BaaS.Interfaces.Autbank.Services;
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

        public async Task<ICadastrarContaResult> IncluirConta(ICadastrarContaSignature signature)
        {
            return await repositorio.IncluirConta(signature);
        }

        public async Task<IListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature)
        {
            return await repositorio.ListarModalidade(signature);
        }

        public async Task<IListarModalidadeResult> ListarModalidades()
        {
            return await repositorio.ListarModalidades();
        }
    }
}
