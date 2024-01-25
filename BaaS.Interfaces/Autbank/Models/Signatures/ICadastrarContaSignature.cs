using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Signatures
{
    public interface ICadastrarContaSignature
    {
        string CODCOLIGADA { get; set; }
        string CODAGENCIA { get; set; }
        DateTime NROCONTA { get; set; }
        string DATAABERTURA { get; set; }
        string TIPODEPOSITO { get; set; }
        string ESPECIE { get; set; }
        string TIPOCONTA { get; set; }
        string CODGERENTE { get; set; }
        string CODPOSTO { get; set; }
        string EXTBLOQUEADO { get; set; }
        string ENVIOEXTRATO { get; set; }
        string PEREXTRATO { get; set; }
        string SOLAUTOMAT { get; set; }
        string TALBLOQUEADO { get; set; }
        string ENVIOTALAO { get; set; }
        string TIPOTALAO { get; set; }
        int QTDFLTALAO { get; set; }
        string ESTMINIMO { get; set; }
        string QTDTALREQ { get; set; }
        int HOMEBANKING { get; set; }
        string NRODIASMOVHB { get; set; }
        string CODTRIBUTACAO { get; set; }
        string CODRETENCAO { get; set; }
        string CODCLIENTE_TITULARES { get; set; }
        string CODENDERECO { get; set; }
        string CODCLIENTE_ENDERECO { get; set; }
        string CODMODALIDADE { get; set; }
        string ISENTOIOF { get; set; }
        string ISENTOJURADP { get; set; }
        string ISENTOJURSAQ { get; set; }
        string ISENTOJURCON { get; set; }
        string TAXAPADADP { get; set; }
        string TAXAPADCON { get; set; }
        string TAXAPADSAQ { get; set; }
        string TRANSFAUTOCA { get; set; }
        double TIPOIOF { get; set; }
        double TAXAADP { get; set; }
        double TAXACON { get; set; }
        double TAXASAQ { get; set; }
        string LIMITE { get; set; }
        DateTime NROCONTR { get; set; }
        DateTime DATACONTRATO { get; set; }
        DateTime DATAVENC { get; set; }
        string DATAVALCTR { get; set; }
        string POSSUILIMADC { get; set; }
        int RENAUTOMAT { get; set; }
        string DIADEBITO { get; set; }
        string INDTARIFACAD { get; set; }
        string INDTAC { get; set; }
        string INDTARIFAFICHACAD { get; set; }
        string TIPOOPERACAO { get; set; }
        DateTime CODUSUARIO { get; set; }
        int DATAATU_PAR { get; set; }
        string ERRO { get; set; }
        string IND_FAZ_TRANS { get; set; }
        string CODFAIXA { get; set; }
        double ORDEMLIMITE { get; set; }
        double TAXACUSTO { get; set; }
        string TAXAINTERNA { get; set; }
        double TPTAXAINTERNA { get; set; }
        string PERCCORRE { get; set; }
        string SITCONTRATO { get; set; }
        string INDTARIFARENCONTRATO { get; set; }
        string INDTARIFAALTCONTRATO { get; set; }
        string INDVALIDADVCONTA { get; set; }
        string MODALORI { get; set; }
        string CODSITUACAO { get; set; }


}
}
