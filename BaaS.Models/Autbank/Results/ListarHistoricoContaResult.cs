using BaaS.Interfaces.Autbank.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;

namespace BaaS.Models.Autbank.Results
{
    public class ListarHistoricoContaResult : IListarHistoricoContaResult
    {
        [SwaggerSchema(Description = "Código do histórico")]
        public string Codigo { get; set; }

        [SwaggerSchema(Description = "Tipo do histórico")]
        public string Tipo { get; set; }

        [SwaggerSchema(Description = "Descrição")]
        public string Historico { get; set; }

        [SwaggerSchema(Description = "Natureza do histórico")]
        public string Natureza { get; set; }

        [SwaggerSchema(Description = "Status do histórico")]
        public string Status { get; set; }
    }
}
