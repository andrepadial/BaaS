using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface IListarModalidadeResult
    {
        [SwaggerSchema(Description = "Código da Modalidade")]
        string Codigo { get; set; }

        [SwaggerSchema(Description = "Descrição da Modalidade")]
        string Modalidade { get; set; }

        [SwaggerSchema(Description = "Tipo de Pessoa F(Física) / J(Jurídica)")]
        string TipoPessoa { get; set; }

    }
}
