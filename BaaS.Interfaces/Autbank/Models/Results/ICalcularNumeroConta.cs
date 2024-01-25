using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface ICalcularNumeroConta
    {
        string NumeroConta { get; set; }
        string NumeroErro { get; set; }
        string Erro { get; set; }


    }
}
