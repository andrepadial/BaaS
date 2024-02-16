using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Infobank
{
    public interface IColigada
    {
        public string Codigo { get; set; }
        public string Coligada { get; set; }
        public string Cnpj { get; set; }
        public string Tipo { get; set; }
        public string CodigoBanco { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
    }
}
