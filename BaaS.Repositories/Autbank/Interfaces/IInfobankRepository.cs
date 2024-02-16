using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.IB;
using BaaS.Models.Autbank.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Repositories.Autbank.Interfaces
{
    public interface IInfobankRepository
    {
        Task<IList<ListarEstadosResult>> ListarEstados();

        Task<IList<ListarEnderecoClienteResult>> ListarEnderecos(IListarDadosClienteSignature signature);

        Task<IList<Coligada>> ListarColigadas();
    }
}
