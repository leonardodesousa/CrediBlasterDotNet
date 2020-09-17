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
    class TelaLiquidacaoService
    {

        //Busca as parcelas abertas e que não tem lote gerado
        public List<DetalheContratoDTO> buscaParcelasAbertas()
        {
            List<DetalheContratoDTO> parcelas = new List<DetalheContratoDTO>();
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            StringBuilder query = new StringBuilder();

            query.Append(" select cd_cli, nr_ctr, nr_prc, tx_jur, vr_jur, vr_prc, vr_tot_prc, dt_venc ");
            query.Append(" from t402cont  where id_sit_parc = 'AB' ");            
            query.Append(" and id_lot = 'N' ");            
            query.Append(" order by dt_venc asc ");

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
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contrato parcela = new Contrato();
                    parcela.cdCli = dr.GetInt64(0);
                    parcela.nrCtr = dr.GetInt64(1);
                    parcela.nrParcela = dr.GetInt64(2);
                    parcela.txJuros = dr.GetDecimal(3);
                    parcela.valorJuros = dr.GetDecimal(4);
                    parcela.valorOriginal = dr.GetDecimal(5);
                    parcela.valorTotal = dr.GetDecimal(6);
                    parcela.dtVenc = dr.GetDateTime(7);
                    parcelas.Add(new DetalheContratoDTO(parcela));
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

            return parcelas;

        }

        public List <DetalheContratoDTO> buscaParcelas(long contrato)
        {
            List<DetalheContratoDTO> parcelas = new List<DetalheContratoDTO>();
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            StringBuilder query = new StringBuilder();

            query.Append(" select cd_cli, nr_ctr, nr_prc, tx_jur, vr_jur, vr_prc, vr_tot_prc, dt_venc ");
            query.Append("from t402cont  where nr_ctr = ");
            query.Append(contrato);
            query.Append(" and id_sit_parc = 'AB' ");
            query.Append(" and id_lot = 'N'"); 
            query.Append(" and nr_prc not in (select parcela from t402lote where contrato = ");
            query.Append(contrato);
            query.Append(")");            
            query.Append(" order by nr_prc ");

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
            } finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contrato parcela = new Contrato();
                    parcela.cdCli = dr.GetInt64(0);
                    parcela.nrCtr = dr.GetInt64(1);
                    parcela.nrParcela = dr.GetInt64(2);
                    parcela.txJuros = dr.GetDecimal(3);
                    parcela.valorJuros = dr.GetDecimal(4);
                    parcela.valorOriginal = dr.GetDecimal(5);
                    parcela.valorTotal = dr.GetDecimal(6);
                    parcela.dtVenc = dr.GetDateTime(7);

                    parcelas.Add(new DetalheContratoDTO(parcela));
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

            return parcelas;
        }

        public PessoaFisicaDTO buscaPessoa(long contrato)
        {
            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");          

            StringBuilder query = new StringBuilder();
            query.Append(" select nm_cli, cd_cli ");
            query.Append(" from t400clie ");
            query.Append(" where cd_cli = (select cd_cli from t402oper where nr_ctr =  ");
            query.Append(contrato);
            query.Append(" ) ");

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
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pessoa.nome = dr.GetString(0);
                    pessoa.codigo = dr.GetInt64(1);
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
        
        public decimal calculaParcela(long cliente, long contrato, long parcela)
        {
            decimal valorCobrado = 0;

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "proc_calculo_liquidacao";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cliente", OracleDbType.Int64, ParameterDirection.Input).Value = cliente;
            cmd.Parameters.Add("contrato", OracleDbType.Int64, ParameterDirection.Input).Value = contrato;
            cmd.Parameters.Add("parcela", OracleDbType.Int64, ParameterDirection.Input).Value = parcela;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                //System.Windows.Forms.MessageBox.Show("Contrato " + nrCtr + " efetivado com sucesso!");
                valorCobrado = this.valorCalculado();
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao tentar efetivar o contrato. " + e);
                throw new System.Exception(e.ToString());
            }
            finally
            {
                conn.Close();
            }

            return valorCobrado;
        }

        public decimal valorCalculado()
        {
            decimal valor = 0;
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            StringBuilder buscaDados = new StringBuilder();
            buscaDados.Append(" select valor from t400param where parametro = 'proc_calc_liq' ");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(buscaDados.ToString(), conn);
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
                    valor = dr.GetDecimal(0);                    
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
            return valor;

        }

        public decimal BuscaValorLiquido(long contrato)
        {
            decimal valor = 0;
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            StringBuilder buscaDados = new StringBuilder();
            buscaDados.Append(" select vr_prc from t402cont where nr_ctr = ");
            buscaDados.Append(contrato);
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(buscaDados.ToString(), conn);
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
                    valor = dr.GetDecimal(0);
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
            return valor;

        }

        public void liquidaParcela(long contrato, long parcela, decimal valorDesconto)
        {
            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
            pessoa = this.buscaPessoa(contrato);
            long cliente = pessoa.codigo;

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
                        
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;

            cmd.CommandText = "proc_baixa_parcelas";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("cliente", OracleDbType.Int64, ParameterDirection.Input).Value = cliente;
            cmd.Parameters.Add("contrato", OracleDbType.Int64, ParameterDirection.Input).Value = contrato;
            cmd.Parameters.Add("parcela", OracleDbType.Int64, ParameterDirection.Input).Value = parcela;            
            cmd.Parameters.Add("valorDesconto", OracleDbType.Decimal, ParameterDirection.Input).Value = valorDesconto;
            //System.Windows.Forms.MessageBox.Show(cmd.Parameters.ToString());

            //SqlParameter sql = new SqlParameter("returnVal",SqlDbType.Decimal);



            try
            {
                conn.Open();
                //OracleDataReader odr = cmd.ExecuteReader();
                //valorDevido = Convert.ToInt64(cmd.ExecuteNonQuery());
                //cmd.Parameters.RemoveAt(0);
                cmd.ExecuteNonQuery();
                //valorDevido = 
                System.Windows.Forms.MessageBox.Show("Parcela liquidada com sucesso!");



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

        public long getProximoLote()
        {
            decimal lote = 0;
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");           

            StringBuilder buscaDados = new StringBuilder();
            buscaDados.Append(" select valor from t400param where parametro = 'prox_lote' ");
            
            
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(buscaDados.ToString(), conn);
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
                    lote = dr.GetDecimal(0);                    
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

            long retorno = Convert.ToInt64(lote);
            return retorno;

        }

        public void atualizaCapaLote(long lote, String tipoLote)
        {
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;

            cmd.CommandText = "proc_atualiza_capa_lote";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("lote", OracleDbType.Int64, ParameterDirection.Input).Value = lote;
            cmd.Parameters.Add("tipoLote", OracleDbType.Int64, ParameterDirection.Input).Value = tipoLote;

            try
            {
                conn.Open();
                //OracleDataReader odr = cmd.ExecuteReader();
                //valorDevido = Convert.ToInt64(cmd.ExecuteNonQuery());
                //cmd.Parameters.RemoveAt(0);
                cmd.ExecuteNonQuery();
                //valorDevido = 
                System.Windows.Forms.MessageBox.Show("Parcela incluida ao lote " + lote);



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


        public void incluirLoteLiquidacao(long lote, long contrato, long parcela, decimal valorDesconto, long sequencial)
        {
            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
            pessoa = this.buscaPessoa(contrato);
            long cliente = pessoa.codigo;

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;

            cmd.CommandText = "proc_lote_liquidacao";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("lote", OracleDbType.Int64, ParameterDirection.Input).Value = lote;
            cmd.Parameters.Add("cliente", OracleDbType.Int64, ParameterDirection.Input).Value = cliente;
            cmd.Parameters.Add("contrato", OracleDbType.Int64, ParameterDirection.Input).Value = contrato;
            cmd.Parameters.Add("parcela", OracleDbType.Int64, ParameterDirection.Input).Value = parcela;
            cmd.Parameters.Add("valorDesconto", OracleDbType.Decimal, ParameterDirection.Input).Value = valorDesconto;
            cmd.Parameters.Add("sequencial", OracleDbType.Decimal, ParameterDirection.Input).Value = sequencial;
            //System.Windows.Forms.MessageBox.Show(cmd.Parameters.ToString());

            //SqlParameter sql = new SqlParameter("returnVal",SqlDbType.Decimal);



            try
            {
                conn.Open();
                //OracleDataReader odr = cmd.ExecuteReader();
                //valorDevido = Convert.ToInt64(cmd.ExecuteNonQuery());
                //cmd.Parameters.RemoveAt(0);
                cmd.ExecuteNonQuery();
                //valorDevido = 
                System.Windows.Forms.MessageBox.Show("Parcela incluida ao lote " + lote);



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

        public void fechaLote(long lote)
        {

            lote += 1;
            StringBuilder update = new StringBuilder();
            update.Append(" update t400param set valor = ");
            update.Append(lote);
            update.Append(" where parametro = 'prox_lote' ");


            //" where parametro = 'prox_lote' ");


            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(update.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;


            /*
            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            */

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
            System.Windows.Forms.MessageBox.Show("Lote " + (lote - 1) + " fechado com sucesso!");
        }

    }
}