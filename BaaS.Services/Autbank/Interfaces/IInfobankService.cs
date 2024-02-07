using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Services.Autbank.Interfaces
{
    public interface IInfobankService
    {
        Task<IList<ListarEstadosResult>> ListarEstados();
        Task<IList<ListarEnderecoClienteResult>> ListarEnderecos(IListarDadosClienteSignature signature);
    }
}
