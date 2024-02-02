using BaaS.Interfaces.Autbank.Models.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.Results
{
    public class ListarMovimentosPixResult : IListarMovimentosPixResult
    {
        public string Tipo { get; set; }
        public string EndToEnd { get; set; }
        public string StatusPix { get; set; }
        public string Natureza { get; set; }
        public string ISPBOrigem { get; set; }
        public string AgOrigem { get; set; }
        public string ContaOrigem { get; set; }
        public string CpfCnpjOrigem { get; set; }
        public string NomeOrigem { get; set; }
        public string ISPBDestino { get; set; }
        public string AgDestino { get; set; }
        public string ContaDestino { get; set; }
        public string CpfCnpjDestino { get; set; }
        public string Destinatario { get; set; }
        public DateTime DataHoraMovimento { get; set; }
        public string ChaveEnderecamento { get; set; }
        public string CampoLivre { get; set; }
        public string Finalidade { get; set; }
        public string OrigemMovimento { get; set; }
        public double? Valor { get; set; }
    }
}
