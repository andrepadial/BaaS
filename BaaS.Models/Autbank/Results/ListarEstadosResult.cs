using BaaS.Interfaces.Autbank.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.Results
{
    public class ListarEstadosResult : IListarEstadosResult
    {
        public string Sigla { get; set; }
        public string Estado { get; set; }
    }
}
