using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Signatures
{
    public interface IConsultarCadastroConta
    {
        string CodigoColigada { get; set; }
        string CodigoAgencia { get; set; }
        string NumeroConta { get; set; }
    }
}
