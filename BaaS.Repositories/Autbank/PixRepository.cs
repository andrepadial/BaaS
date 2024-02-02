using BaaS.Interfaces.Autbank.Models.Results;
using BaaS.Interfaces.Autbank.Models.Signatures;
using BaaS.Models.Autbank.Results;
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
    public class PixRepository : IPixRepository
    {
        public async Task<IList<ListarMovimentosPixResult>> ListarMovimentos(IListarMovimentosPixSignature signature)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.PixConnection))
            {
                conn.Open();

                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@DATACORTE", signature.DataCorte);
                    parameters.Add("@NUMEROCONTA", signature.NumeroConta);
                    parameters.Add("@EndToEnd", signature.EndToEnd);

                    var result = await conn.QueryAsync<ListarMovimentosPixResult>("BAAS_PIX_COMPROVANTE", parameters, null, null, CommandType.StoredProcedure);
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
