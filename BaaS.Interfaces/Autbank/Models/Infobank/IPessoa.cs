using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Interfaces.Autbank.Models.Infobank
{
    public interface IPessoa
    {
        public string CpfCnpj { get; set; }
        public string Sequencia { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string TipoPessoa { get; set; }
        public string Situacao { get; set; }
        public string Email { get; set; }
        public double Ganho { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string Faturamento { get; set; }
        public string UF { get; set; }
        public string SITUACAOATUAL { get; set; }
        public string REGIMETRIBUTACAO { get; set; }
        public string ORIGEMCADASTRO { get; set; }
        public string CODFUNCAO { get; set; }
        public string CODCATEGORIA { get; set; }
        public string CODISPB { get; set; }
        public string CODPESSOA { get; set; }
        public string CODCONTROLE { get; set; }
        public string INDTIPIDENTCLI { get; set; }
        public DateTime DATACADASTRO { get; set; }
        public string CODNATUREZA { get; set; }
        public string INDPERMITE_BC { get; set; }
        public string PORTE { get; set; }
        public string UF_MUNICIPIO { get; set; }
        public string CODMUNICIPIO { get; set; }
        public DateTime DATAVENCIMENTO { get; set; }
        public string PARAISOFISCAL { get; set; }
        public string INDAUTBANK { get; set; }
        public DateTime DATABALANCO { get; set; }
        public double PATRIMONIOLIQUIDO { get; set; }
        public string ENTREGUE_CPF { get; set; }
        public string ENTREGUE_RG { get; set; }
        public string ENTREGUE_RESIDENCIA { get; set; }
        public string ENTREGUE_FICHA { get; set; }
        public string ENTREGUE_VISITA { get; set; }
        public string ENTREGUE_CARTAO { get; set; }
        public string ENTREGUE_PROPOSTA { get; set; }
        public string CODPAIS { get; set; }
        public double RENDA_TOTAL { get; set; }
        public string CPFCONJUGE { get; set; }
        public string SEQUENCIACONJUGE { get; set; }
        public DateTime DATABALANCETE { get; set; }
        public DateTime DATACONSULTABACEN { get; set; }
        public string SITUACAOBACEN { get; set; }
        public DateTime DATAFATURAMENTO_DE { get; set; }
        public DateTime DATAFATURAMENTO_ATE { get; set; }
        public string EXIBIR_RELATORIO_PENDENCIAS { get; set; }
        public string CODCAPITALSOCIAL { get; set; }
        public string CODNATUREZAEMPRESA { get; set; }
        public string ESCOLARIDADE { get; set; }
        public int NUMDEPENDENTES { get; set; }
        public string CODTIPOEMPRESA { get; set; }
        public double COMPRAS_ULTIMO_EXERCICIO { get; set; }
        public double VENDAS_ULTIMO_EXERCICIO { get; set; }
        public string NOMEFANTASIAANT { get; set; }
        public DateTime DATAATUALIZACAONOMEFANTASIA { get; set; }
        public DateTime DATASERASA { get; set; }
        public string ENDERECO_ELETRONICO { get; set; }
        public DateTime ULTIMA_ALTERACAO_CONTRATUAL { get; set; }
        public string INDPERMITE_PCAM { get; set; }
        public string CODEXTERNO { get; set; }
        public string TITULAR { get; set; }
        public string MENOR_EMANCIPADO { get; set; }
        public string ESPOLIO { get; set; }
        public string CODSEGMENTO { get; set; }
        public int ANO_INICIO_ATIVIDADE { get; set; }
        public string DOMICILIADO_EXTERIOR { get; set; }
        public string CODPAIS_DOMICILIADO_EXTERIOR { get; set; }
        public string INDPERMITE_FATCA { get; set; }
        public string CODFATCA { get; set; }
        public string OBSERVACOES_FATCA { get; set; }
        public string ETNIA { get; set; }
        public string SITUACAORECEITA { get; set; }
        public string CODCONTROLERECEITA { get; set; }
        public DateTime DATASITUACAORECEITA { get; set; }
        public string ARQUIVORECEITA { get; set; }
        public string INDPERMITE_EMAIL { get; set; }
        public string CLIENTEDIGITAL { get; set; }
        public string CODSETORCNAE { get; set; }
        public string INVESTIDOR_QUALIFICADO { get; set; }
        public string PUBLICO_ALVO_FUNDO { get; set; }
        public string FUNDO_INVESTIDOR_QUALIFICADO { get; set; }
        public string FATURAMENTO_PASSIVO { get; set; }
        public string NAO_PARTICIPANTE_GIIN { get; set; }
        public string NOME_PATROCINADORA { get; set; }
        public string CNPJ_PATROCINADORA { get; set; }
        public string GIIN_PATROCINADORA { get; set; }
        public string SUBCLASSEFATCA { get; set; }
        public string DIGITORECEITA { get; set; }
        public string NAO_COMUNICA_INSTITUICAO { get; set; }
        public string NAO_DOCUMENTADA_CRS { get; set; }
        public DateTime DATAENTRADAESTRANGEIRO { get; set; }
        public string CODCRS { get; set; }
        public string INDBACENJUD { get; set; }
        public string TIPO_CLI_EXTERIOR { get; set; }
        public string COD_CLI_EXTERIOR { get; set; }
        public string CNPJ_EMPRESA_LIDER { get; set; }
        public string PROVINCIA_ESTRANGEIRO { get; set; }
        public string CIDADE_ESTRANGEIRO { get; set; }
        public double ATIVO_TOTAL { get; set; }
        public string CODPAISCAPITALABERTO { get; set; }
        public string INFORMAFISCALBC { get; set; }
        public string NIVELRISCOPLD { get; set; }
        public string NAO_PARTICIPA_EXPURGO { get; set; }
        public string CODNATUREZA_JURIDICA { get; set; }
        public string NIF_OBRIGATORIO { get; set; }


    }
}
