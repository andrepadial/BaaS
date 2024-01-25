using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Signatures
{
    public interface ICancelarContrato
    {
        string CodigoColigada { get; set; }
        string CodigoAgencia { get; set; }
        string NumeroConta { get; set; }
        string CodigoModalidadeOriginal { get; set; }
        string DataValidadeContrato { get; set; }
        string CadastradoMesmoDia { get; set; }
        string IsentoJurosAdp { get; set; }
        string IsentoJurosSaque { get; set; }
        string AplicarTaxaPadraoADP { get; set; }
        string AplicarTaxaPadraoSaque { get; set; }
        double TaxaADP { get; set; }
        double TaxaSaque { get; set; }
    }
}
