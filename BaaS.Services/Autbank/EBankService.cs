using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
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

        public async Task<ListarSaldoContarResult> ListarSaldoConta(IListarSaldoContaSignature signature)
        {
            var result = await repositorio.ListarSaldoConta(signature);
            
            if (result != null)
            {
                result.SaldoDisponivel = result.SaldoD0 + result.Limite - result.Cpmf - result.SaldoBloqueadoCip - result.SaldoBloqueado - result.ValorBloqueado + result.SaldoProvisorio;
            }

            return result;
        }
    }
}
