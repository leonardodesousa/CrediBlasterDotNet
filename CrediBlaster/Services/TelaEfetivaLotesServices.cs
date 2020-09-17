using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;
using System.Data;
using System.Data.SqlClient;


namespace CrediBlaster
{
    class TelaEfetivaLotesServices
    {
        public List<LoteDTO> buscaLotes()
        {
            List<LoteDTO> lotes = new List<LoteDTO>();
            StringBuilder query = new StringBuilder();
            query.Append(" select lote, valor from t402cplt ");
            query.Append(" where situacao = 'FEC' and tipo_lote = 'LIQ' ");
            query.Append(" order by lote ");

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Impossível conectar ao Banco: " + e);
            }

            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                //foreach(DataRow drw in dt.Rows)
                {
                    LoteDTO lote = new LoteDTO();
                    lote.lote = dr.GetInt64(0);
                    lote.valor = dr.GetDecimal(1);
                   // lote.Contrato = dr.GetInt64(2);
                    lotes.Add(lote);
                    lote = null;                   
                }

            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            }

            conn.Close();


            return lotes;
        }

        public void efetvaLoteLiquidacao(long lote, String tipoLote)
        {
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "proc_efetiva_lote";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("lote", OracleDbType.Int64, ParameterDirection.Input).Value = lote;
            cmd.Parameters.Add("tipoLote", OracleDbType.Varchar2, ParameterDirection.Input).Value = tipoLote;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Lote " + lote + " efetivado com sucesso!");
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar efetivar o lote. " + e);
                throw new System.Exception(e.ToString());
            }
            finally
            {
                conn.Close();
            }

        }        
    }
}
