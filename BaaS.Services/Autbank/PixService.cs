using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using BaaS.Repositories.Autbank;
using BaaS.Repositories.Autbank.Interfaces;
using BaaS.Services.Autbank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Services.Autbank
{
    public class PixService : IPixService
    {

        private readonly IPixRepository repositorio;

        public PixService(IPixRepository _repositorio)
        {
            repositorio = _repositorio;
        }
        public async Task<IList<ListarMovimentosPixResult>> ListarMovimentos(IListarMovimentosPixSignature signature)
        {
            return await repositorio.ListarMovimentos(signature);
        }
    }
}
