using BaaS.Interfaces.Autbank.Models.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.Signatures
{
    public class ListarHistoricoContaSignature : IListarHistoricoContaSignature
    {
        public string Codigo { get; set; }
    }
}
