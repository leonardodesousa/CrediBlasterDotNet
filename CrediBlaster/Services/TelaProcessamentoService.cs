using CrediBlaster.DTO;
using CrediBlaster.Model;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster.Services
{
    class TelaProcessamentoService
    {
        public DateTime buscaDataAtual()
        {
            DateTime dataatual = DateTime.Today;
            //String dataBase = "sqlserver";
            String dataBase = "oracle";
            List<DetalheContratoDTO> contratos = new List<DetalheContratoDTO>();
            StringBuilder query = new StringBuilder();
            query.Append(" select dataatual  ");
            query.Append(" from agencias  ");


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
                        //DetalheContratoDTO contrato = new DetalheContratoDTO();
                        // contrato.CdCli = dr.GetInt64(0);
                        dataatual = dr.GetDateTime(0);
                        
                    }

                }
                catch (OracleException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
                }

                conn.Close();
                return dataatual;
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
                        //DetalheContratoDTO contrato = new DetalheContratoDTO();
                        //contrato.CdCli = Convert.ToInt64(dr.GetValue(0));
                        dataatual = Convert.ToDateTime(dr.GetValue(0));
                        
                    }

                }
                catch (SqlException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
                return dataatual;
            }
        }



        public List<DetalheContratoDTO> detalheOperacoes()
        {
            //String dataBase = "sqlserver";
            String dataBase = "oracle";            
            List<DetalheContratoDTO> contratos = new List<DetalheContratoDTO>();
            StringBuilder query = new StringBuilder();
            query.Append(" cd_cli, nm_cli, qt_amo, nr_ctr, tx_jur, vl_ori, vl_liq ");
            query.Append(" from t402oper  ");
            query.Append(" where t402oper.id_st = 'AB' ");
            query.Append(" order by t402oper.dt_inc asc");


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
                        //Contrato contrato = new Contrato();
                        Contrato contrato = new Contrato();  

                        contrato.cdCli = dr.GetInt64(0);
                        contrato.nomeCli = dr.GetString(1);
                        contrato.qtParcelas = dr.GetInt64(2);
                        contrato.nrCtr = dr.GetInt64(3);
                        contrato.txJuros = dr.GetDecimal(4);
                        contrato.valorOriginal = dr.GetDecimal(5);
                        contrato.valorTotal = dr.GetDecimal(6);
                        contratos.Add(new DetalheContratoDTO(contrato));                        

                        contrato = null;
                    }

                }
                catch (OracleException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
                }

                conn.Close();
                return contratos;
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
                        Contrato contrato = new Contrato();
                        contrato.cdCli = Convert.ToInt64(dr.GetValue(0));
                        contrato.nomeCli = dr.GetString(1);
                        contrato.qtParcelas = Convert.ToInt64(dr.GetValue(2));
                        contrato.nrCtr = Convert.ToInt64(dr.GetValue(3));
                        contrato.txJuros = Convert.ToDecimal(dr.GetValue(4));
                        contrato.valorOriginal = Convert.ToDecimal(dr.GetValue(5));
                        contrato.valorTotal = Convert.ToDecimal(dr.GetValue(6));
                        contratos.Add(new DetalheContratoDTO(contrato));
                        contrato = null;
                    }

                }
                catch (SqlException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
                return contratos;
            }
        }

        public void IniciaProcessamento()
        {
            DateTime dataAtual = buscaDataAtual();
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "sp_processamentoagencia";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("unidade", OracleDbType.Int64, ParameterDirection.Input).Value = lote;
            //cmd.Parameters.Add("empresa", OracleDbType.Varchar2, ParameterDirection.Input).Value = tipoLote;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Processamento do dia "+ dataAtual.ToString("dd/MM/yyyy") + " concluído com sucesso!");
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar iniciar o processamento. " + e);
                throw new System.Exception(e.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
