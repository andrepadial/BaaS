using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Signatures
{
    public interface IListarMovimentosPixSignature
    {
        public DateTime DataCorte { get; set; }
        public string NumeroConta { get; set; }
        public string? EndToEnd { get; set; }
    }
}
