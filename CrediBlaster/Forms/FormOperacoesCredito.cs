using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrediBlaster.Services;
using CrediBlaster.Model;
using System.Drawing.Drawing2D;
using CrediBlaster.DTO;

namespace CrediBlaster
{
    public partial class FormOperacoesCredito : Form
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

        char contClic = 'A';
        public FormOperacoesCredito()
        {
            InitializeComponent();

            //Traz as informações de abrangência em tela
            Abrangencia abrangencia = new Abrangencia();
            AgenciaDTO agencia = new AgenciaDTO();

            agencia = abrangencia.buscaAgencia();

            textBoxEmpresa.Text = agencia.empresa.ToString();
            textBoxUnidade.Text = agencia.unidade.ToString();
            textBoxDescrAgencia.Text = agencia.descricaoAgencia.ToString();
            textBoxDataAtual.Text = agencia.dataAtual.ToString("dd/MM/yyyy");
            
            // Efeito degradê
            this.Paint += new PaintEventHandler(set_background);

            // iniciar maximizada a janela
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            TelaOperacoesServices tos = new TelaOperacoesServices();
            PessoaFisicaDTO pessoa = new PessoaFisicaDTO();
            long cdCli = Convert.ToInt64(textBoxCodCliente.Text);
            pessoa = tos.buscaPessoa(cdCli);

            textBoxNomeCliente.Text = pessoa.nome;
            textBoxSituacao.Text = pessoa.situacao;

            comboBoxTipoVencimento.Items.Clear();

            comboBoxTipoVencimento.Items.Add("Postecipado");
            comboBoxTipoVencimento.Items.Add("Antecipado");

            comboBox1.Items.Clear();
            comboBox1.Items.Add("PRICE");
            comboBox1.Items.Add("SAC");
            //comboBox1.Items.Add(atual)
            contClic = 'N';

        }

        protected void buttonCalcular_Click(object sender, EventArgs e)
        {
                        

            if (contClic == 'N')
            {
                contClic = 'S';
                long cdCli = Convert.ToInt64(textBoxCodCliente.Text);
                long qtdAmort = Convert.ToInt64(textBoxParcelas.Text);
                decimal txJuros = Convert.ToDecimal(textBoxTxJuros.Text);
                long carencia = Convert.ToInt64(textBoxCarencia.Text);
                decimal valor = Convert.ToDecimal(textBoxValorOperacao.Text);
                String metodoCalculo = comboBox1.SelectedItem.ToString().Trim();
                

                TelaOperacoesServices tos = new TelaOperacoesServices();
                tos.calculaOperacao(cdCli, qtdAmort, txJuros, carencia, valor);
                long nrCtr = tos.buscaUltimoContrato();
                //MessageBox.Show(nrCtr.ToString());
                TelaContratosServices tls = new TelaContratosServices();
                List<DetalheContratoDTO> lista = new List<DetalheContratoDTO>();
                //long cdCLi = tls.buscaClienteContrato(textBoxCtrSelecionado.Text);                
                tls.simulaParcelas(cdCli, nrCtr, metodoCalculo);
                lista = tls.gridParcelasService(Convert.ToString(nrCtr));
                List<DetalheContratoDTO> parcelasGrid = new List<DetalheContratoDTO>();


                int contador = 0;
                dataGridView1.Rows.Clear();
                while (contador < lista.Count)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[contador].Cells[0].Value = lista[contador].nrParcela;
                    dataGridView1.Rows[contador].Cells[1].Value = lista[contador].txJuros;
                    dataGridView1.Rows[contador].Cells[2].Value = lista[contador].valorJuros.ToString("C");
                    dataGridView1.Rows[contador].Cells[3].Value = lista[contador].valorOriginal.ToString("C");
                    dataGridView1.Rows[contador].Cells[4].Value = lista[contador].valorTotal.ToString("C");
                    dataGridView1.Rows[contador].Cells[5].Value = lista[contador].dtVenc.ToShortDateString();
                    contador++;
                }

                tos.atualizaContrato(nrCtr, "PE");
                textBoxNumeroContrato.Text = nrCtr.ToString();

                DetalheContratoDTO contrato = new DetalheContratoDTO();
                contrato = tos.buscaInfomracaoAdicional(nrCtr);
                textBoxJurosCalculado.Text = contrato.valorJuros.ToString("C");
                textBoxTotalAPagar.Text = contrato.valorTotal.ToString("C");
                textBoxPrazoTotal.Text = contrato.prazoTotal.ToString();
                               

            } if (contClic != 'S')
            {
                MessageBox.Show("Você já clicou neste botão!");
                if (textBoxNumeroContrato.Text != null && !string.IsNullOrWhiteSpace(textBoxNumeroContrato.Text))
                {
                    TelaOperacoesServices tos = new TelaOperacoesServices();
                    long contrato = Convert.ToInt64(textBoxNumeroContrato.Text);
                    tos.cancelaOperacaoPendente(contrato);
                }

                textBoxCarencia.Clear();
                textBoxCodCliente.Clear();
                textBoxNumeroContrato.Clear();
                textBoxNomeCliente.Clear();
                textBoxTxJuros.Clear();
                textBoxValorOperacao.Clear();
                textBoxSituacao.Clear();
                textBoxCarencia.Clear();
                textBoxParcelas.Clear();
                textBoxTotalAPagar.Clear();
                textBoxJurosCalculado.Clear();
                comboBoxTipoVencimento.Items.Clear();
                dataGridView1.Rows.Clear();

            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormOperacoesCredito_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSituacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoVencimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void textBoxParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar essa operação? ", "Cancelar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBoxNumeroContrato.Text != null && !string.IsNullOrWhiteSpace(textBoxNumeroContrato.Text))
                {
                    TelaOperacoesServices tos = new TelaOperacoesServices();
                    long contrato = Convert.ToInt64(textBoxNumeroContrato.Text);
                    tos.cancelaOperacaoPendente(contrato);
                }

                textBoxCarencia.Clear();
                textBoxCodCliente.Clear();
                textBoxNumeroContrato.Clear();
                textBoxNomeCliente.Clear();
                textBoxTxJuros.Clear();
                textBoxValorOperacao.Clear();
                textBoxSituacao.Clear();
                textBoxCarencia.Clear();
                textBoxParcelas.Clear();
                textBoxTotalAPagar.Clear();
                textBoxJurosCalculado.Clear();
                comboBoxTipoVencimento.Items.Clear();
                dataGridView1.Rows.Clear();
                textBoxPrazoTotal.Clear();

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValorOperacao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmar essa operação? ", "Finalizar operação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBoxNumeroContrato.Text != null && !string.IsNullOrWhiteSpace(textBoxNumeroContrato.Text))
                {
                    TelaOperacoesServices tos = new TelaOperacoesServices();
                    long contrato = Convert.ToInt64(textBoxNumeroContrato.Text);
                    tos.atualizaContrato(contrato, "AB");

                    MessageBox.Show("Contrato " + contrato + " finalizado com sucesso!");

                    textBoxCarencia.Clear();
                    textBoxCodCliente.Clear();
                    textBoxNumeroContrato.Clear();
                    textBoxNomeCliente.Clear();
                    textBoxTxJuros.Clear();
                    textBoxValorOperacao.Clear();
                    textBoxSituacao.Clear();
                    textBoxCarencia.Clear();
                    textBoxParcelas.Clear();
                    textBoxJurosCalculado.Clear();
                    textBoxTotalAPagar.Clear();
                    comboBoxTipoVencimento.Items.Clear();
                    dataGridView1.Rows.Clear();
                    comboBox1.Items.Clear();                    
                
                }

                

            }
            else if (dialogResult == DialogResult.No)
            {

            }


        }

        private void groupBoxDadosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUnidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescrAgencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJurosCalculado_TextChanged(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(set_background);

        }

        private void textBoxTotalAPagar_TextChanged(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(set_background);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPrazoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
