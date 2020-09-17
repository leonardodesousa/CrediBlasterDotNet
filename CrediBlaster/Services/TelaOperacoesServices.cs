using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrediBlaster.DTO;
using CrediBlaster.Model;
using Oracle.DataAccess.Client;

namespace CrediBlaster
{
    class TelaOperacoesServices
    {
        public PessoaFisicaDTO buscaPessoa(long cdCli)
        {
            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
            StringBuilder query = new StringBuilder();
            query.Append(" select nm_cli, nr_cic, ");
            query.Append(" case id_sit ");
            query.Append(" when 'A' then 'ATIVO' ");
            query.Append(" when 'V' then 'VENCIDO' ");
            query.Append(" when 'I' then 'INATIVO' ");
            query.Append(" end ");
            query.Append(" from t400clie where cd_cli = ");
            query.Append(cdCli);

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {
                conn.Open();
            } catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Impossível conectar ao Banco: " + e);
            }

            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pessoa.nome = dr.GetString(0);
                    pessoa.cpf = dr.GetString(1);
                    pessoa.situacao = dr.GetString(2);
                }

            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            }
            finally
            {
                conn.Close();
            }

            return pessoa;
        }

        public void calculaOperacao(long cdCli, long qtdAmortizacoes, decimal txJuros, long carencia, decimal valor)
        {
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "proc_insere_oper";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cdCli", OracleDbType.Int64, ParameterDirection.Input).Value = cdCli;
            cmd.Parameters.Add("qtdAmortizacoes", OracleDbType.Int64, ParameterDirection.Input).Value = qtdAmortizacoes;
            cmd.Parameters.Add("txJuros",OracleDbType.Decimal, ParameterDirection.Input).Value = txJuros;
            cmd.Parameters.Add("carencia", OracleDbType.Int64, ParameterDirection.Input).Value = carencia;
            cmd.Parameters.Add("valor", OracleDbType.Decimal, ParameterDirection.Input).Value = valor;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                
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

        public long buscaUltimoContrato()
        {
            long nrCtr = 0;
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            StringBuilder query = new StringBuilder();
            query.Append("select valor from t400geseq where nome_tabela = 't402oper'");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            //DataTable dt = new DataTable();


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
                
                {                    
                    nrCtr = dr.GetInt64(0);
                    
                }

            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            }

            conn.Close();
            return nrCtr;
        }
        

        public void atualizaContrato(long contrato, String situacao)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" update t402oper  ");
            query.Append(" set id_st = ");
            query.Append("'"+ situacao +"'");
            query.Append(" where nr_ctr = ");            
            query.Append(contrato);

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            
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
            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            }

            conn.Close();
        }

        public void cancelaOperacaoPendente(long contrato)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" delete t402oper where id_st = 'PE' and nr_ctr = ");
            query.Append(contrato);

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

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
            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            } finally
            {
                conn.Close();
            }            
        }

        public DetalheContratoDTO buscaInfomracaoAdicional(long nrCtr)
        {
            Contrato contrato = new Contrato();
            StringBuilder sb = new StringBuilder();
            sb.Append(" select vr_jur, vl_liq, prazoTotal from t402oper ");
            sb.Append(" where nr_ctr = ");
            sb.Append(nrCtr);

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(sb.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

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
                {
                    contrato.valorJuros = dr.GetDecimal(0);
                    contrato.valorTotal = dr.GetDecimal(1);
                    contrato.prazoTotal = dr.GetInt64(2);
                }

            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            }
            finally
            {
                conn.Close();
            }
            return new DetalheContratoDTO(contrato); 
        }

        public decimal testaFunction(String cliente, String contrato, String parcela)
        {
            long cdCli = Convert.ToInt64(cliente);
            long nrCtr = Convert.ToInt64(contrato);
            long parc = Convert.ToInt64(parcela);

            decimal valorDevido = 0;
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;

            cmd.CommandText = "fn_calculo_liquidacao"; 
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandType = System.Data.CommandType.Text;
            
            cmd.Parameters.Add("cliente", OracleDbType.Int64, ParameterDirection.Input).Value = cliente;
            cmd.Parameters.Add("contrato", OracleDbType.Int64, ParameterDirection.Input).Value = contrato;
            cmd.Parameters.Add("parcela", OracleDbType.Int64, ParameterDirection.Input).Value = parcela;
            cmd.Parameters.Add("valorDevido", OracleDbType.Int64, ParameterDirection.ReturnValue).Value = valorDevido;
            System.Windows.Forms.MessageBox.Show(cmd.Parameters.ToString());

            //SqlParameter sql = new SqlParameter("returnVal",SqlDbType.Decimal);



            try
            {
                conn.Open();
                //OracleDataReader odr = cmd.ExecuteReader();
                //valorDevido = Convert.ToInt64(cmd.ExecuteNonQuery());
                //cmd.Parameters.RemoveAt(0);
                cmd.ExecuteNonQuery(); 
                //valorDevido = 



            } catch (SqlException e)
            {
                throw new System.Exception(e.ToString());
            } finally
            {
                conn.Close();
            }
            return valorDevido;
        }
        
    }
}
