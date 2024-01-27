using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public class ListarModalidadeResult : IListarModalidadeResult
    {
        [SwaggerSchema(Description = "Código da Modalidade")]
        public string Codigo { get; set; }

        [SwaggerSchema(Description = "Descrição da Modalidade")]
        public string Modalidade {get; set; }

        [SwaggerSchema(Description = "Tipo de Pessoa F(Física) / J(Jurídica)")]
        public string TipoPessoa {get; set; }
    }
}
