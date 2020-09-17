using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrediBlaster.Model;
using CrediBlaster.DTO;

namespace CrediBlaster.Services
{
    class Abrangencia
    {
        public AgenciaDTO buscaAgencia()
        {
            Agencia agencia = new Agencia();
            

            //String dataBase = "sqlserver";
            String dataBase = "oracle";            
            StringBuilder query = new StringBuilder();
            query.Append(" select empresa, unidade, descricaoAgencia, dataatual, processamentoIniciado from agencias ");

            if (dataBase == "oracle")
            {
                 
                ConnexaoBD conBD = new ConnexaoBD();
                String oradb = conBD.conecta(dataBase);

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

                        agencia.empresa = dr.GetInt16(0);
                        agencia.unidade = dr.GetInt16(1);
                        agencia.descricaoAgencia = dr.GetString(2);
                        agencia.dataAtual = dr.GetDateTime(3);
                        agencia.processamentoIniciado = Convert.ToBoolean(dr.GetInt16(4));
                        

                    }

                }
                catch (OracleException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
                }

                conn.Close();
                AgenciaDTO agenciaDTO = new AgenciaDTO(agencia);
                return agenciaDTO;
            }
            else
            {
                ConnexaoBD conBD = new ConnexaoBD();
                String sqldb = conBD.conecta(dataBase);
                SqlConnection conn = new SqlConnection(sqldb);

                try
                {
                    conn.Open();
                }
                catch (SqlException e)
                {
                    System.Windows.Forms.MessageBox.Show("Impossível conectar ao Banco: " + e);
                }

                try
                {
                    SqlCommand sqlcmd = new SqlCommand(query.ToString(), conn);
                    //SqlDataReader dr = sqlcmd.ExecuteReader();
                    IDataReader dr = sqlcmd.ExecuteReader();

                    // if (!dr.IsDBNull(dr.GetOrdinal("cd_cli")))
                    while (dr.Read())
                    //foreach(DataRow drw in dt.Rows)
                    {
                        agencia.empresa = Convert.ToInt16(dr.GetValue(0));
                        agencia.unidade = Convert.ToInt16(dr.GetValue(1));
                        agencia.descricaoAgencia = Convert.ToString(dr.GetValue(2));
                        agencia.dataAtual = Convert.ToDateTime(dr.GetValue(3));
                        agencia.processamentoIniciado = Convert.ToBoolean(dr.GetValue(4));

                    }

                }
                catch (SqlException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
                AgenciaDTO agenciaDTO = new AgenciaDTO(agencia);
                return agenciaDTO;


            }
        }
    }
}
