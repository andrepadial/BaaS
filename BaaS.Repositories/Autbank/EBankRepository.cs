using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Repositories.Autbank.Interfaces;
using BaaS.Repositories.Connections;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Repositories.Autbank
{
    public class EBankRepository : IEBankRepository
    {
        public async Task<CadastrarContaResult> IncluirConta(ICadastrarContaSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.EBankConnection))
            {
                conn.Open();

                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CODCOLIGADA", signature.CODCOLIGADA);
                    parameters.Add("@CODAGENCIA", signature.CODAGENCIA);
                    parameters.Add("@NROCONTA", signature.NROCONTA);
                    parameters.Add("@DATAABERTURA", signature.DATAABERTURA);
                    parameters.Add("@TIPODEPOSITO", signature.TIPODEPOSITO);
                    parameters.Add("@ESPECIE", signature.ESPECIE);
                    parameters.Add("@TIPOCONTA", signature.TIPOCONTA);
                    parameters.Add("@CODGERENTE", signature.CODGERENTE);
                    parameters.Add("@CODPOSTO", signature.CODPOSTO);
                    parameters.Add("@EXTBLOQUEADO", signature.EXTBLOQUEADO);
                    parameters.Add("@ENVIOEXTRATO", signature.ENVIOEXTRATO);
                    parameters.Add("@PEREXTRATO", signature.PEREXTRATO);
                    parameters.Add("@SOLAUTOMAT", signature.SOLAUTOMAT);
                    parameters.Add("@TALBLOQUEADO", signature.TALBLOQUEADO);
                    parameters.Add("@ENVIOTALAO", signature.ENVIOTALAO);
                    parameters.Add("@TIPOTALAO", signature.TIPOTALAO);
                    parameters.Add("@QTDFLTALAO", signature.QTDFLTALAO);
                    parameters.Add("@ESTMINIMO", signature.ESTMINIMO);
                    parameters.Add("@QTDTALREQ", signature.QTDTALREQ);
                    parameters.Add("@HOMEBANKING", signature.HOMEBANKING);
                    parameters.Add("@NRODIASMOVHB", signature.NRODIASMOVHB);
                    parameters.Add("@CODTRIBUTACAO", signature.CODTRIBUTACAO);
                    parameters.Add("@CODRETENCAO", signature.CODRETENCAO);
                    parameters.Add("@CODCLIENTE_TITULARES", signature.CODCLIENTE_TITULARES);
                    parameters.Add("@CODENDERECO", signature.CODENDERECO);
                    parameters.Add("@CODCLIENTE_ENDERECO", signature.CODCLIENTE_ENDERECO);
                    parameters.Add("@CODMODALIDADE", signature.CODMODALIDADE);
                    parameters.Add("@ISENTOIOF", signature.ISENTOIOF);
                    parameters.Add("@ISENTOJURADP", signature.ISENTOJURADP);
                    parameters.Add("@ISENTOJURSAQ", signature.ISENTOJURSAQ);
                    parameters.Add("@ISENTOJURCON", signature.ISENTOJURCON);
                    parameters.Add("@TAXAPADADP", signature.TAXAPADADP);
                    parameters.Add("@TAXAPADCON", signature.TAXAPADCON);
                    parameters.Add("@TAXAPADSAQ", signature.TAXAPADSAQ);
                    parameters.Add("@TRANSFAUTOCA", signature.TRANSFAUTOCA);
                    parameters.Add("@TIPOIOF", signature.TIPOIOF);
                    parameters.Add("@TAXAADP", signature.TAXAADP);
                    parameters.Add("@TAXACON", signature.TAXACON);
                    parameters.Add("@TAXASAQ", signature.TAXASAQ);
                    parameters.Add("@LIMITE", signature.LIMITE);
                    parameters.Add("@NROCONTR", signature.NROCONTR);
                    parameters.Add("@DATACONTRATO", signature.DATACONTRATO);
                    parameters.Add("@DATAVENC", signature.DATAVENC);
                    parameters.Add("@DATAVALCTR", signature.DATAVALCTR);
                    parameters.Add("@POSSUILIMADC", signature.POSSUILIMADC);
                    parameters.Add("@RENAUTOMAT", signature.RENAUTOMAT);
                    parameters.Add("@DIADEBITO", signature.DIADEBITO);
                    parameters.Add("@INDTARIFACAD", signature.INDTARIFACAD);
                    parameters.Add("@INDTAC", signature.INDTAC);
                    parameters.Add("@INDTARIFAFICHACAD", signature.INDTARIFAFICHACAD);
                    parameters.Add("@TIPOOPERACAO", signature.TIPOOPERACAO);
                    parameters.Add("@CODUSUARIO", signature.CODUSUARIO);
                    parameters.Add("@DATAATU_PAR", signature.DATAATU_PAR);
                    parameters.Add("@ERRO", signature.ERRO);
                    parameters.Add("@IND_FAZ_TRANS", signature.IND_FAZ_TRANS);
                    parameters.Add("@CODFAIXA", signature.CODFAIXA);
                    parameters.Add("@ORDEMLIMITE", signature.ORDEMLIMITE);
                    parameters.Add("@TAXACUSTO", signature.TAXACUSTO);
                    parameters.Add("@TAXAINTERNA", signature.TAXAINTERNA);
                    parameters.Add("@TPTAXAINTERNA", signature.TPTAXAINTERNA);
                    parameters.Add("@PERCCORRE", signature.PERCCORRE);
                    parameters.Add("@SITCONTRATO", signature.SITCONTRATO);
                    parameters.Add("@INDTARIFARENCONTRATO", signature.INDTARIFARENCONTRATO);
                    parameters.Add("@INDTARIFAALTCONTRATO", signature.INDTARIFAALTCONTRATO);
                    parameters.Add("@INDVALIDADVCONTA", signature.INDVALIDADVCONTA);
                    parameters.Add("@MODALORI", signature.MODALORI);
                    parameters.Add("@CODSITUACAO", signature.CODSITUACAO);


                    var result = await conn.QueryFirstOrDefaultAsync<CadastrarContaResult>("SP_CADASTRA_CONTA_CC_AUTK", parameters, null, null, CommandType.StoredProcedure);

                    conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }

        public async Task<ListarModalidadeResult> ListarModalidade(IListarModalidadeSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.EBankConnection))
            {
                conn.Open();
                string comandoSql = "SELECT CODMODAL AS Codigo, DESCRICAO AS Modalidade, PESSOA AS TipoPessoa ";
                comandoSql += " FROM MODALIDADE ";
                comandoSql += " WHERE CODMODAL = '" + signature.Codigo + "' ";
                comandoSql += " ORDER BY CAST(CODMODAL AS INT)";

                try
                {
                    var result = await conn.QueryFirstOrDefaultAsync<ListarModalidadeResult>(comandoSql, null, null, null, CommandType.Text);

                    conn.Close();
                    return result;

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<IList<ListarModalidadeResult>> ListarModalidades()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.EBankConnection))
            {
                conn.Open();
                string comandoSql = "SELECT CODMODAL AS Codigo, DESCRICAO AS Modalidade, PESSOA AS TipoPessoa ";
                comandoSql += " FROM MODALIDADE ";
                comandoSql += " ORDER BY CAST(CODMODAL AS INT)";

                try
                {
                    var result = await conn.QueryAsync<ListarModalidadeResult>(comandoSql, null, null, null, CommandType.Text);

                    conn.Close();
                    return result.ToList();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
