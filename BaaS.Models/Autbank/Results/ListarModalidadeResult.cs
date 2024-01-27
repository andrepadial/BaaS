using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public class ListarModalidadeResult : IListarModalidadeResult
    {
        public string Codigo { get; set; }
        public string Modalidade {get; set; }
        public string TipoPessoa {get; set; }
    }
}
