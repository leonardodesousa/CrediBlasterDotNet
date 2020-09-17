using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;
using System.Data;
using System.Data.SqlClient;


namespace CrediBlaster.Services
{
    class TelaParametrosService
    {

        public void cadastraFeriado(String descricao, DateTime data )
        {
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "proc_cadastra_feriados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("descricao", OracleDbType.Varchar2, ParameterDirection.Input).Value = descricao;
            cmd.Parameters.Add("data", OracleDbType.Date, ParameterDirection.Input).Value = data;


            try
            {                
                conn.Open();                
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Feriado cadastrado com sucesso!");
            }
            catch (SqlException e)
            {
                throw new System.Exception(e.ToString());                
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
