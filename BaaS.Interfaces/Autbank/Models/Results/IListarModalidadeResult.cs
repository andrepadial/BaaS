using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface IListarModalidadeResult
    {
        string Codigo { get; set; }
        string Modalidade { get; set; }
        string TipoPessoa { get; set; }


    }
}
