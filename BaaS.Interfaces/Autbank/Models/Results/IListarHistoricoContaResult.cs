using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface IListarHistoricoContaResult
    {
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Historico { get; set; }
        public string Natureza { get; set; }
        public string Status { get; set; }


    }
}
