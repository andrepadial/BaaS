using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Signatures
{
    public interface IBloquearValorContaIdEmpotencia
    {
        string CodigoColigada { get; set; }
        string CodigoAgencia { get; set; }
        string NumeroConta { get; set; }
        string CodigoMotivoBloqueio { get; set; }
        double Valor { get; set; }
        string CodigoSistemaOrigem { get; set; }
        string Descricao { get; set; }
        bool ValidarSaldoConta { get; set; }
        string Usuario { get; set; }
        string IdEmpotente { get; set; }
        string Chave { get; set; }

    }
}
