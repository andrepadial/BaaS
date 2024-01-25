using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface IConsultarCadastroConta
    {
        public DateTime DataAbertura { get; set; }
        public string Gerente { get; set; }
        public string Situacao { get; set; }
        public double Saldo { get; set; }
        public double SaldoBloqueado { get; set; }
        public string Produto { get; set; }
        public string CodigoModalidade { get; set; }
        public string ExtratoBloqueado { get; set; }
        public string PeriodicidadeExtrato { get; set; }
        public string TalaoBloqueado { get; set; }
        public string Tributacao { get; set; }
        public double TaxaAdp { get; set; }
        public double TaxaContrato { get; set; }
        public double TaxaSaque { get; set; }
        public double Limite { get; set; }
        public DateTime DataContrato { get; set; }
        public DateTime DataVencimentoContrato { get; set; }
        public double EncargoAcumulado { get; set; }
        public double IofAcumulado { get; set; }
        public double CpmfAcumulado { get; set; }
        public DateTime UltimaDataMovimento { get; set; }
        public string QuantidadeChequeSustado { get; set; }
        public double LimiteAdicional { get; set; }
        public double TaxaAdicional { get; set; }
        public double CorrecaoAdicionalAcumulada { get; set; }
        public double ValorBloqueado { get; set; }
        public double SaldoCip { get; set; }
        public string Modalidade { get; set; }
        public string CodigoMoeda { get; set; }
        public string PrePos { get; set; }
        public double IofAdicional { get; set; }
        public double Cet { get; set; }

    }
}
