using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface IListarEstadosResult
    {
        public string Sigla { get; set; }
        public string Estado { get; set; }
    }
}
