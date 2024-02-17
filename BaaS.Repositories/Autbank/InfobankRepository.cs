using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.IB;
using BaaS.Models.Autbank.Results;
using BaaS.Repositories.Autbank.Interfaces;
using BaaS.Repositories.Connections;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace BaaS.Repositories.Autbank
{
    public class InfobankRepository : IInfobankRepository
    {
        

        public async Task<IList<Coligada>> ListarColigadas()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.InfobankConnection))
            {
                conn.Open();

                try
                {
                    var result = await conn.QueryAsync<Coligada>("BAAS_INFOBANK_LISTAR_COLIGADAS", null, null, null, CommandType.StoredProcedure);
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

        public async Task<IList<ListarEnderecoClienteResult>> ListarEnderecos(IListarDadosClienteSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.InfobankConnection))
            {
                conn.Open();

                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@CodigoCliente", signature.Codigo);
                    
                    var result = await conn.QueryAsync<ListarEnderecoClienteResult>("BAAS_INFOBANK_ENDERECOS", parameters, null, null, CommandType.StoredProcedure);
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

        public async Task<IList<ListarEstadosResult>> ListarEstados()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.InfobankConnection))
            {
                conn.Open();

                try
                {
                    var result = await conn.QueryAsync<ListarEstadosResult>("BAAS_LISTAR_ESTADOS", null, null, null, CommandType.StoredProcedure);
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

