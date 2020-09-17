using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrediBlaster.DTO;

using System.IO;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using CrediBlaster.Model;

namespace CrediBlaster
{
    class TelaContratosServices
    {
        public List<DetalheContratoDTO> buscaContratosAbertos()
        {
            //String dataBase = "sqlserver";
            String dataBase = "oracle";
            List<DetalheContratoDTO> contratos = new List<DetalheContratoDTO>();
            StringBuilder query = new StringBuilder();
            query.Append(" select t400clie.cd_cli, t400clie.nm_cli, t402oper.nr_ctr  from t400clie, t402oper ");
            query.Append(" where t400clie.cd_cli = t402oper.cd_cli ");
            query.Append(" and t402oper.id_st = 'AB' ");
            query.Append(" order by t402oper.nr_ctr");


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
                        Contrato contrato = new Contrato();
                        contrato.cdCli = dr.GetInt64(0);
                        contrato.nomeCli = dr.GetString(1);
                        contrato.nrCtr = dr.GetInt64(2);
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
                        contrato.nrCtr = Convert.ToInt64(dr.GetValue(2));                        
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
        
        public List<DetalheContratoDTO> gridParcelasService(String nrCtr)
        {
            List<DetalheContratoDTO> parcelas = new List<DetalheContratoDTO>();
            StringBuilder query = new StringBuilder();
            query.Append(" select nr_prc,tx_jur,vr_jur,vr_prc,vr_tot_prc, dt_venc ");
            query.Append(" from t402simu ");
            query.Append(" where nr_ctr = ");
            query.Append(nrCtr);
            query.Append(" order by nr_prc ");

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


                    Contrato contrato = new Contrato();
                    contrato.nrParcela = dr.GetInt64(0);
                    contrato.txJuros = dr.GetDecimal(1);
                    contrato.valorJuros = dr.GetDecimal(2);
                    contrato.valorOriginal = dr.GetDecimal(3);
                    contrato.valorTotal = dr.GetDecimal(4);
                    contrato.dtVenc = dr.GetDateTime(5);

                    parcelas.Add(new DetalheContratoDTO(contrato));
                    contrato = null;
                }

            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            }

            conn.Close();
            return parcelas;
        }

        public bool simulaParcelas(long cdCli, long nrCtr, String metodoCalculo /*= "PRICE"*/)
        {

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "proc_contrato_simu_v4";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cdCli", OracleDbType.Int64,ParameterDirection.Input).Value = cdCli;
            cmd.Parameters.Add("nrCtr", OracleDbType.Int64, ParameterDirection.Input).Value = nrCtr;            
            cmd.Parameters.Add("metodoCalculo", OracleDbType.Varchar2, ParameterDirection.Input).Value = metodoCalculo;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            } catch (SqlException e)
            {
                return false;
                throw new System.Exception(e.ToString());
            } finally
            {
                conn.Close();
            }
            
        }

        public long buscaClienteContrato(String nrCtr)
        {
            long cliente = 0;
            StringBuilder query = new StringBuilder();
            query.Append(" select cd_cli from t402oper ");
            query.Append(" where nr_ctr = ");
            query.Append(nrCtr);

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
                {
                    cliente = dr.GetInt64(0);                                     
                }

            }
            catch (OracleException e)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco: " + e);
            } finally
            {
                conn.Close();
            }
            return cliente;

        }    

        public void efetivaContrato(long cdCLi, long nrCtr)
        {
            //long cliente = Convert.ToInt64(cdCLi);
            //long contrato = Convert.ToInt64(nrCtr);

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");
            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand();
            OracleParameter param = new OracleParameter();
            cmd.Connection = conn;
            cmd.CommandText = "proc_contrato_v2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cdCli", OracleDbType.Int64, ParameterDirection.Input).Value = cdCLi;
            cmd.Parameters.Add("nrCtr", OracleDbType.Int64, ParameterDirection.Input).Value = nrCtr;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Contrato " + nrCtr + " efetivado com sucesso!");
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
        }
        
        public void imprimeContrato(String nrCtr)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();

            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();            
            Contrato contrato = new Contrato();

            String caminho = @"D:\PDF\" + "CONTRATO_" + nrCtr + ".PDF";
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao tentar acessar o arquivo. O arquivo está aberto?");
            }

            doc.Open();

            StringBuilder buscaDados = new StringBuilder();
            buscaDados.Append(" select nm_cli, nr_cic, (select vl_ori from t402oper where nr_ctr = ");
            buscaDados.Append(nrCtr + ") ");
            buscaDados.Append(" , (select tx_jur from t402oper where nr_ctr = ");
            buscaDados.Append(nrCtr + ")");
            buscaDados.Append("  from t400clie ");
            buscaDados.Append(" where cd_cli in (select cd_cli from t402oper where nr_ctr = ");
            buscaDados.Append(nrCtr + ") ");

            ConnexaoBD conBD = new ConnexaoBD();
            String oradb = conBD.conecta("oracle");

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
                    pessoa.nome = dr.GetString(0);
                    pessoa.cpf = dr.GetString(1);
                    contrato.valorOriginal = dr.GetDecimal(2);
                    contrato.txJuros = dr.GetDecimal(3);                    
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

            DetalheContratoDTO contratoDTO = new DetalheContratoDTO(contrato);


            String dados = "";
            //Criando a variável parágrafo
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));
            //estipulando o alinhamento, JUSTIFICADO
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            doc.AddHeader("Header", "Financeira Credifácil LTDA");
            //adicionando o texto
            paragrafo.Add("                     CONFISSÃO DE DÍVIDA                 \n");

            paragrafo.Add("\n     Pelo presente instrumento particular, " + pessoa.nome + ", "  +
                          "inscrito(a) no CPF sob o nº " + pessoa.cpf + " e , " +
                          "CrediBlaster LTDA, no CNPJ sob o nº 43.698.316/0001-01" + ", firmam " +
                          "contrato de empréstimo/financiamento que será regido pelas cláusulas e condições adiante estabelecidas.\n ");

            paragrafo.Add("\n     Cláusula 1ª. Na data da assinatura deste contrato o(a) MUTUANTE empresta ao(à) MUTUÁRIO(a) a quantia " +
                          "de " + contratoDTO.valorOriginal.ToString("C") + ", mediante transferência bancária para conta de titularidade do(a) MUTUÁRIO(a)," +
                          " qual seja, \n");

            paragrafo.Add("\n     Cláusula 2ª. A instituição se compromete a restituir ao(à) MUTUANTE a quantia mutuada especificada na cláusula " +
                          "anterior, no dia (dia) de (mês) de (ano), acrescida de atualização monetária calculada com base no INPC/IBGE e juros" +
                          " de "+ contratoDTO.txJuros +"% ao mês, os quais serão calculados a partir desta data até o dia da efetiva liquidação da dívida.\n");

            paragrafo.Add("\n     Cláusula 3ª. Na eventual falta do INPC/IBGE a atualização monetária será realizada com base no IGP-M/FGV. Na falta também" +
                          " deste, com base em outro índice equivalente reconhecido pelo Governo Federal.\n");

            paragrafo.Add("\n     Cláusula 4ª. Fica facultado ao(à) MUTUÁRIO(a) quitar a dívida antes da data de seu vencimento, hipótese em que os encargos financeiros " +
                         "(atualização monetária e juros) serão calculados proporcionalmente até o dia do efetivo pagamento.\n");

            paragrafo.Add("\n     Cláusula 5ª. Ocorrendo impontualidade no cumprimento da obrigação do(a) MUTUÁRIO(a), este(a) incorrerá em multa de 3% (três por cento) " +
                          "sobre o valor corrigido e com juros do empréstimo, considerando-se este contrato como um título executivo extrajudicial de dívida líquida e certa, " +
                          "sujeitando-se o(a) MUTUÁRIO(a) ao pagamento das despesas processuais e honorários advocatícios de 20% (vinte por cento) sobre o valor da ação que " +
                          "será movida pelo(a) MUTUANTE para execução da dívida.\n");

            paragrafo.Add("\n     Cláusula 6ª. A eventual tolerância do(a) MUTUANTE pelo não cumprimento de obrigações contratuais por parte do(a) MUTUÁRIO(a) será considerada como " +
                          "mera liberalidade e não importará novação, perdão ou alteração contratual.\n");

            paragrafo.Add("\n Esteio - RS, 20 de Outubro de 2019 \n");

            paragrafo.Add("\n________________________________\n");

            paragrafo.Add("         " + pessoa.nome);



            //adicionando o parágrafo ao documento
            doc.Add(paragrafo);
            //fechando o documento
            doc.Close();

            System.Windows.Forms.MessageBox.Show("Contrato gerado em: " + caminho);

        }
        

    }
}