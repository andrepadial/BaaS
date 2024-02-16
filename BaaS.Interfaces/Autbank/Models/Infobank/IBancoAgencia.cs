using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Infobank
{
    public interface IBancoAgencia
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
