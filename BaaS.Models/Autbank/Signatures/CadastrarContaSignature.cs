using BaaS.Interfaces.Autbank.Models.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Models.Autbank.Signatures
{
    public class CadastrarContaSignature : ICadastrarContaSignature
    {
        public string CODCOLIGADA {get; set; }
        public string CODAGENCIA {get; set; }
        public string NROCONTA {get; set; }
        public string DATAABERTURA {get; set; }
        public string TIPODEPOSITO {get; set; }
        public string ESPECIE {get; set; }
        public string TIPOCONTA {get; set; }
        public string CODGERENTE {get; set; }
        public string CODPOSTO {get; set; }
        public string EXTBLOQUEADO {get; set; }
        public string ENVIOEXTRATO {get; set; }
        public string PEREXTRATO {get; set; }
        public string SOLAUTOMAT {get; set; }
        public string TALBLOQUEADO {get; set; }
        public string ENVIOTALAO {get; set; }
        public string TIPOTALAO {get; set; }
        public int QTDFLTALAO {get; set; }
        public string ESTMINIMO {get; set; }
        public string QTDTALREQ {get; set; }
        public int HOMEBANKING {get; set; }
        public string NRODIASMOVHB {get; set; }
        public string CODTRIBUTACAO {get; set; }
        public string CODRETENCAO {get; set; }
        public string CODCLIENTE_TITULARES {get; set; }
        public string CODENDERECO {get; set; }
        public string CODCLIENTE_ENDERECO {get; set; }
        public string CODMODALIDADE {get; set; }
        public string ISENTOIOF {get; set; }
        public string ISENTOJURADP {get; set; }
        public string ISENTOJURSAQ {get; set; }
        public string ISENTOJURCON {get; set; }
        public string TAXAPADADP {get; set; }
        public string TAXAPADCON {get; set; }
        public string TAXAPADSAQ {get; set; }
        public string TRANSFAUTOCA {get; set; }
        public double TIPOIOF {get; set; }
        public double TAXAADP {get; set; }
        public double TAXACON {get; set; }
        public double TAXASAQ {get; set; }
        public string LIMITE {get; set; }
        public DateTime NROCONTR {get; set; }
        public DateTime DATACONTRATO {get; set; }
        public DateTime DATAVENC {get; set; }
        public string DATAVALCTR {get; set; }
        public string POSSUILIMADC {get; set; }
        public int RENAUTOMAT {get; set; }
        public string DIADEBITO {get; set; }
        public string INDTARIFACAD {get; set; }
        public string INDTAC {get; set; }
        public string INDTARIFAFICHACAD {get; set; }
        public string TIPOOPERACAO {get; set; }
        public DateTime CODUSUARIO {get; set; }
        public int DATAATU_PAR {get; set; }
        public string ERRO {get; set; }
        public string IND_FAZ_TRANS {get; set; }
        public string CODFAIXA {get; set; }
        public double ORDEMLIMITE {get; set; }
        public double TAXACUSTO {get; set; }
        public string TAXAINTERNA {get; set; }
        public double TPTAXAINTERNA {get; set; }
        public string PERCCORRE {get; set; }
        public string SITCONTRATO {get; set; }
        public string INDTARIFARENCONTRATO {get; set; }
        public string INDTARIFAALTCONTRATO {get; set; }
        public string INDVALIDADVCONTA {get; set; }
        public string MODALORI {get; set; }
        public string CODSITUACAO {get; set; }
    }
}
