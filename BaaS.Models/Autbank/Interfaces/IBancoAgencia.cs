using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.Interfaces
{
    public interface IBancoAgencia
    {
        [SwaggerSchema(Description = "Código da agência")]
        public string CodigoAgencia { get; set; }

        [SwaggerSchema(Description = "Nome da agência")]
        public string Agencia { get; set; }

        [SwaggerSchema(Description = "Cnpj da agência")]
        public string CnpjAgencia { get; set; }

        [SwaggerSchema(Description = "Agência ativa S / N")]
        public string Ativa { get; set; }

        [SwaggerSchema(Description = "Cidade da agência")]
        public string Cidade { get; set; }

        [SwaggerSchema(Description = "UF da agência")]
        public string Uf { get; set; }

        [SwaggerSchema(Description = "Endereço da agência")]
        public string Endereco { get; set; }
    }
}
