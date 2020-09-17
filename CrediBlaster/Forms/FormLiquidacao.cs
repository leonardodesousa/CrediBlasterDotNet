using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrediBlaster.Services;
using CrediBlaster.Model;
using CrediBlaster.DTO;

namespace CrediBlaster
{
    public partial class FormLiquidacao : Form
    {
        // Efeito degradê
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        public FormLiquidacao()
        {
            InitializeComponent();
            // Efeito degradê
            this.Paint += new PaintEventHandler(set_background);


            // iniciar maximizada a janela
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


            //Traz as informações de abrangência em tela
            Abrangencia abrangencia = new Abrangencia();
            AgenciaDTO agencia = new AgenciaDTO();

            agencia = abrangencia.buscaAgencia();

            textBoxEmpresa.Text = agencia.empresa.ToString();
            textBoxUnidade.Text = agencia.unidade.ToString();
            textBoxDescrAgencia.Text = agencia.descricaoAgencia.ToString();
            textBoxDataAtual.Text = agencia.dataAtual.ToString("dd/MM/yyyy");
        }        

            

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            if(textBoxNumeroCtr.Text == "" || textBoxNumeroCtr.Text == " " && checkBoxContratosAbertos.Checked)
            {
                //long contrato = Convert.ToInt64(textBoxNumeroCtr.Text);
                PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
                TelaLiquidacaoService tls = new TelaLiquidacaoService();
               // pessoa = tls.buscaPessoa(contrato);

                //textBoxNomeCliente.Text = pessoa.Nome;
                //textBoxCodCliente.Text = pessoa.codigo.ToString();


                TelaLiquidacaoService tlq = new TelaLiquidacaoService();
                List<DetalheContratoDTO> parcelas = new List<DetalheContratoDTO>();

                parcelas = tlq.buscaParcelasAbertas();

                int contador = 0;
                dataGridView1.Rows.Clear();
                while (contador < parcelas.Count)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[contador].Cells[0].Value = parcelas[contador].cdCli;
                    dataGridView1.Rows[contador].Cells[1].Value = parcelas[contador].nrCtr;
                    dataGridView1.Rows[contador].Cells[2].Value = parcelas[contador].nrParcela;
                    dataGridView1.Rows[contador].Cells[3].Value = parcelas[contador].txJuros;
                    dataGridView1.Rows[contador].Cells[4].Value = parcelas[contador].valorJuros.ToString("C");
                    dataGridView1.Rows[contador].Cells[5].Value = parcelas[contador].valorOriginal.ToString("C");
                    dataGridView1.Rows[contador].Cells[6].Value = parcelas[contador].valorTotal.ToString("C");
                    dataGridView1.Rows[contador].Cells[7].Value = parcelas[contador].dtVenc.ToShortDateString();
                    contador++;
                }


                
                
            } else if (textBoxNumeroCtr.Text == "" || textBoxNumeroCtr.Text == " ")
            {
                MessageBox.Show("Você deve informar um número de contrato válido.");


            } else
            {
                long contrato = Convert.ToInt64(textBoxNumeroCtr.Text);
                PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
                TelaLiquidacaoService tls = new TelaLiquidacaoService();
                pessoa = tls.buscaPessoa(contrato);

                textBoxNomeCliente.Text = pessoa.nome;
                textBoxCodCliente.Text = pessoa.codigo.ToString();


                TelaLiquidacaoService tlq = new TelaLiquidacaoService();
                List<DetalheContratoDTO> parcelas = new List<DetalheContratoDTO>();

                parcelas = tlq.buscaParcelas(contrato);

                int contador = 0;
                dataGridView1.Rows.Clear();
                while (contador < parcelas.Count)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[contador].Cells[0].Value = parcelas[contador].cdCli;
                    dataGridView1.Rows[contador].Cells[1].Value = parcelas[contador].nrCtr;
                    dataGridView1.Rows[contador].Cells[2].Value = parcelas[contador].nrParcela;
                    dataGridView1.Rows[contador].Cells[3].Value = parcelas[contador].txJuros;
                    dataGridView1.Rows[contador].Cells[4].Value = parcelas[contador].valorJuros.ToString("C");
                    dataGridView1.Rows[contador].Cells[5].Value = parcelas[contador].valorOriginal.ToString("C");
                    dataGridView1.Rows[contador].Cells[6].Value = parcelas[contador].valorTotal.ToString("C");
                    dataGridView1.Rows[contador].Cells[7].Value = parcelas[contador].dtVenc.ToShortDateString();
                    contador++;
                }

            }           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormLiquidacao liquidacao = new FormLiquidacao();
            liquidacao.Show();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            TelaLiquidacaoService tls = new TelaLiquidacaoService();
            DetalheContratoDTO contrato = new DetalheContratoDTO();
            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();

            if (textBoxValorDesconto.Text == " " || textBoxValorDesconto.Text == "")
            {
                textBoxValorDesconto.Text = "0,00";
            }


            //textBoxValorPago.Text = "0,00";


            long NumeroContrato = Convert.ToInt64(textBoxNumeroCtr.Text);
            pessoa = tls.buscaPessoa(NumeroContrato);

            long cliente = pessoa.codigo;
            long parcela = Convert.ToInt64(textBoxParcela.Text);


            tls.calculaParcela(cliente, NumeroContrato, parcela);
            textBoxTotCalculado.Text = tls.valorCalculado().ToString("C");
            decimal valorLiquido = tls.BuscaValorLiquido(NumeroContrato);
            decimal totCalc = tls.valorCalculado();
            //decimal totCalc = Convert.ToInt64(textBoxTotCalculado.Text);
            decimal juros = totCalc - valorLiquido;
            textBoxJurosCobrado.Text = juros.ToString("C");



            decimal desconto = Convert.ToDecimal(textBoxValorDesconto.Text);
            //decimal totCalculado = Convert.ToDecimal(textBoxTotCalculado.Text);
            decimal valorAPagar = (tls.valorCalculado() - desconto);

            textBoxValorPago.Text = valorAPagar.ToString("C");

        }

        private void buttonLiquidar_Click(object sender, EventArgs e)
        {
            decimal valorDesconto = 0;
            TelaLiquidacaoService tls = new TelaLiquidacaoService();
            long contrato = Convert.ToInt64(textBoxNumeroCtr.Text);
            long parcela = Convert.ToInt64(textBoxParcela.Text);
            if (textBoxValorDesconto.Text == " " || textBoxValorDesconto.Text == "")
            {
                textBoxValorDesconto.Text = "0,00";
                valorDesconto = Convert.ToDecimal(textBoxValorDesconto.Text);
            }
            valorDesconto = Convert.ToDecimal(textBoxValorDesconto.Text);
            string strTest = textBoxValorPago.Text.ToString();
            decimal value = decimal.Parse(strTest.Replace("R$", ""));

            //String valorPg = textBoxValorPago.Text.ToString();
            //decimal valorPago = Convert.ToDecimal(value);

            //MessageBox.Show(value.ToString());

            tls.liquidaParcela(contrato, parcela, valorDesconto);

        }

        private void ButtonIncluirLote_Click(object sender, EventArgs e)
        {
            if (textBoxSeq.Text == " " || textBoxSeq.Text == "")
            {
                textBoxSeq.Text = "1";
            }
            TelaLiquidacaoService tls = new TelaLiquidacaoService();            
            if (textBoxNumLote.Text == " " || textBoxNumLote.Text == "")
            {
                String strLote;
                strLote = tls.getProximoLote().ToString();
                textBoxNumLote.Text = strLote;
            }

            long lote = Convert.ToInt64(textBoxNumLote.Text);
            long contrato = Convert.ToInt64(textBoxNumeroCtr.Text);
            long parcela = Convert.ToInt64(textBoxParcela.Text);
            decimal desconto = Convert.ToDecimal(textBoxValorDesconto.Text);
            long sequencial = Convert.ToInt64(textBoxSeq.Text);

            tls.incluirLoteLiquidacao(lote, contrato, parcela, desconto, sequencial);

            sequencial = sequencial + 1;
            textBoxSeq.Text = sequencial.ToString();

            if (textBoxNumeroCtr.Text == "" || textBoxNumeroCtr.Text == " ")
            {
                MessageBox.Show("Verifique os campos obrigatórios.");
            }
            else
            {
                //long contrato = Convert.ToInt64(textBoxNumeroCtr.Text);
                PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
                //TelaLiquidacaoService tls = new TelaLiquidacaoService();
                pessoa = tls.buscaPessoa(contrato);

                textBoxNomeCliente.Text = pessoa.nome;
                textBoxCodCliente.Text = pessoa.codigo.ToString();


                TelaLiquidacaoService tlq = new TelaLiquidacaoService();
                List<DetalheContratoDTO> parcelas = new List<DetalheContratoDTO>();

                parcelas = tlq.buscaParcelas(contrato);

                int contador = 0;
                dataGridView1.Rows.Clear();
                while (contador < parcelas.Count)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[contador].Cells[0].Value = parcelas[contador].cdCli;
                    dataGridView1.Rows[contador].Cells[1].Value = parcelas[contador].nrCtr;
                    dataGridView1.Rows[contador].Cells[2].Value = parcelas[contador].nrParcela;
                    dataGridView1.Rows[contador].Cells[3].Value = parcelas[contador].txJuros;
                    dataGridView1.Rows[contador].Cells[4].Value = parcelas[contador].valorJuros.ToString("C");
                    dataGridView1.Rows[contador].Cells[5].Value = parcelas[contador].valorOriginal.ToString("C");
                    dataGridView1.Rows[contador].Cells[6].Value = parcelas[contador].valorTotal.ToString("C");
                    dataGridView1.Rows[contador].Cells[7].Value = parcelas[contador].dtVenc.ToShortDateString();
                    contador++;
                }

            }
        }

        private void textBoxNumLote_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValorDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSeq_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFecharLote_Click(object sender, EventArgs e)
        {
            TelaLiquidacaoService tls = new TelaLiquidacaoService();
            DialogResult dialogResult = MessageBox.Show("Deseja fechar o lote " + textBoxNumLote.Text + " ? ", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                long lote = Convert.ToInt64(textBoxNumLote.Text);
                tls.fechaLote(lote);

                textBoxCodCliente.Text = " ";
                textBoxJurosCobrado.Text = " ";
                textBoxNomeCliente.Text = " ";
                textBoxNumeroCtr.Text = " ";
                textBoxNumLote.Text = " ";
                textBoxSeq.Text = " ";
                textBoxTotCalculado.Text = " ";
                textBoxParcela.Text = " ";
                textBoxValorPago.Text = " ";
                dataGridView1.Rows.Clear();
            }


        }

        private void FormLiquidacao_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonNovaTela_Click(object sender, EventArgs e)
        {
            FormLiquidacaoNovo liquidacaoNovo = new FormLiquidacaoNovo();
            liquidacaoNovo.Show();
            

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
