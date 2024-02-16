using BaaS.Interfaces.Autbank.Models.Infobank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.IB
{
    public class BancoAgencia : IBancoAgencia
    {
        public string CodigoAgencia { get; set; }
        public string Agencia { get; set; }
        public string CnpjAgencia { get; set; }
        public string Ativa { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Endereco { get; set; }
    }
}
