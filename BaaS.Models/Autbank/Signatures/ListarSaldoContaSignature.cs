using BaaS.Interfaces.Autbank.Models.Signatures;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.Signatures
{
    public class ListarSaldoContaSignature : IListarSaldoContaSignature
    {
        [SwaggerSchema(Description = "Código da Coligada")]
        public string CodigoColigada {get; set; }

        [SwaggerSchema(Description = "Código da agência")]
        public string CodigoAgencia {get; set; }

        [SwaggerSchema(Description = "Número da Conta")]
        public string Conta {get; set; }
    }
}
