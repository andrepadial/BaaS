using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Results
{
    public interface IListarSaldoContarResult
    {
        [SwaggerSchema(Description = "Número da conta")]
        public string Conta { get; set; }

        [SwaggerSchema(Description = "Titular da conta")]
        public string Titular { get; set; }

        [SwaggerSchema(Description = "Saldo da Conta em D0")]
        public double SaldoD0 { get; set; }

        [SwaggerSchema(Description = "Limites de valores da Conta")]
        public double Limite { get; set; }

        [SwaggerSchema(Description = "CPMF")]
        public double Cpmf { get; set; }

        [SwaggerSchema(Description = "Saldo bloqueado na CIP")]
        public double SaldoBloqueadoCip { get; set; }

        [SwaggerSchema(Description = "Saldo bloqueado por ordem judicial")]
        public double SaldoBloqueado { get; set; }

        [SwaggerSchema(Description = "Saldo bloqueado via admistrativo da IF")]
        public double ValorBloqueado { get; set; }

        [SwaggerSchema(Description = "Saldo provisório (para finais de semana e operações de PIX)")]
        public double SaldoProvisorio { get; set; }

        [SwaggerSchema(Description = "Saldo Disponível")]
        public double SaldoDisponivel { get; set; }

    }
}
