using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Signatures
{
    public interface ICancelarPrevisao
    {
        string CodigoSistemaOrigem { get; set; }
        string NumeroControle { get; set; }
    }
}
