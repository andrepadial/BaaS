using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface ICancelarPrevisao
    {
        string CodigoErro { get; set; }
        string MensagemErro { get; set; }
    }
}
