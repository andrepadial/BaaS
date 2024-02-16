using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace BaaS.Interfaces.Autbank.Models.Infobank
{
    public interface IBanco
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string AtivoSTR { get; set; }
        public List<IBancoAgencia> Agencias { get; set; }
    }
}
