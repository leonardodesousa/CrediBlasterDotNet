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
    public partial class FormContratos : Form
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

            //Traz as informações de abrangência em tela
            Abrangencia abrangencia = new Abrangencia();
            AgenciaDTO agencia = new AgenciaDTO();

            agencia = abrangencia.buscaAgencia();

            textBoxEmpresa.Text = agencia.empresa.ToString();
            textBoxUnidade.Text = agencia.unidade.ToString();
            textBoxDescrAgencia.Text = agencia.descricaoAgencia.ToString();
            textBoxDataAtual.Text = agencia.dataAtual.ToString("dd/MM/yyyy");
        }

        public FormContratos()
        {
            InitializeComponent();
            // Efeito degradê
            this.Paint += new PaintEventHandler(set_background);

            // iniciar maximizada a janela
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }        

        private void FormContratos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetCrediblaster.T402SIMU'. Você pode movê-la ou removê-la conforme necessário.
            //this.t402SIMUTableAdapter.Fill(this.dataSetCrediblaster.T402SIMU);

        }        

        public void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String selectedNodeText = e.Node.Text;
            textBoxCtrSelecionado.Text = selectedNodeText;

            String contratoSeleciona = selectedNodeText;


        }


        private void buttonSimulaParcelas_Click(object sender, EventArgs e)
        {
            List<DetalheContratoDTO> lista = new List<DetalheContratoDTO>();
            long nrCtrL = Convert.ToInt64(textBoxCtrSelecionado.Text);
            TelaContratosServices tls = new TelaContratosServices();
            long cdCLi = tls.buscaClienteContrato(textBoxCtrSelecionado.Text);            
            //tls.simulaParcelas(cdCLi, nrCtrL);

            List<DetalheContratoDTO> parcelasGrid = new List<DetalheContratoDTO>();
            lista = tls.gridParcelasService(textBoxCtrSelecionado.Text);

            int contador = 0;
            dataGridView1.Rows.Clear();
            while(contador < lista.Count)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[contador].Cells[0].Value = lista[contador].nrParcela;
                dataGridView1.Rows[contador].Cells[1].Value = lista[contador].txJuros;
                dataGridView1.Rows[contador].Cells[2].Value = lista[contador].valorJuros.ToString("C");
                dataGridView1.Rows[contador].Cells[3].Value = lista[contador].valorOriginal.ToString("C") ;
                dataGridView1.Rows[contador].Cells[4].Value = lista[contador].valorTotal.ToString("C");
                dataGridView1.Rows[contador].Cells[5].Value = lista[contador].dtVenc.ToShortDateString();                
                contador++;
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<DetalheContratoDTO> lista = new List<DetalheContratoDTO>();
            TelaContratosServices tcs = new TelaContratosServices();
            lista = tcs.buscaContratosAbertos();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            
            int cont = 0;            

            treeView1.Nodes.Add("Contratos");
            while (cont < lista.Count)
            {                
            treeView1.Nodes[0].Nodes.Add(lista.ElementAt(cont).nrCtr.ToString());
            treeView1.Nodes[0].Nodes[cont].Nodes.Add(lista.ElementAt(cont).cdCli.ToString()+  " - " + 
                lista.ElementAt(cont).nomeCli);
                cont++;
            }
            treeView1.EndUpdate();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCtrSelecionado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonImprimirCtr_Click(object sender, EventArgs e)
        {
            TelaContratosServices tls = new TelaContratosServices();
            tls.imprimeContrato(textBoxCtrSelecionado.Text);
            
        }

        private void buttonEfetivarCtr_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja efetivar o contrato"+ textBoxCtrSelecionado.Text +" ? ", "Finalizar operação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TelaContratosServices tls = new TelaContratosServices();
                long nrCtrL = Convert.ToInt64(textBoxCtrSelecionado.Text);
                long cdCLi = tls.buscaClienteContrato(textBoxCtrSelecionado.Text);
                tls.efetivaContrato(cdCLi, nrCtrL);

                List<DetalheContratoDTO> lista = new List<DetalheContratoDTO>();
                TelaContratosServices tcs = new TelaContratosServices();
                lista = tcs.buscaContratosAbertos();

                /* Montar a árvore de contratos novamente e limpar o grid de parcelas 25/01/2019*/
                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();

                int cont = 0;

                treeView1.Nodes.Add("Contratos");
                while (cont < lista.Count)
                {
                    treeView1.Nodes[0].Nodes.Add(lista.ElementAt(cont).nrCtr.ToString());
                    treeView1.Nodes[0].Nodes[cont].Nodes.Add(lista.ElementAt(cont).cdCli.ToString() + " - " +
                        lista.ElementAt(cont).nomeCli);
                    cont++;
                }
                treeView1.EndUpdate();
                dataGridView1.Rows.Clear();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOperacoesCredito formOperacoes = new FormOperacoesCredito();
            formOperacoes.Show();

            List<DetalheContratoDTO> lista = new List<DetalheContratoDTO>();
            TelaContratosServices tcs = new TelaContratosServices();
            lista = tcs.buscaContratosAbertos();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();          
            int cont = 0;            

            treeView1.Nodes.Add("Contratos");
            while (cont < lista.Count)
            {
                treeView1.Nodes[0].Nodes.Add(lista.ElementAt(cont).nrCtr.ToString());
                treeView1.Nodes[0].Nodes[cont].Nodes.Add(lista.ElementAt(cont).cdCli.ToString() + " - " +
                    lista.ElementAt(cont).nomeCli);
                cont++;
            }
            treeView1.EndUpdate();
        }

        private void buttonFuncao_Click(object sender, EventArgs e)
        {
            String cliente = "253";
            String contrato = "1004";
            String parcela = "1";
            TelaOperacoesServices tos = new TelaOperacoesServices();
            decimal valor = tos.testaFunction(cliente, contrato, parcela);

        }

        private void buttonLiquidar_Click(object sender, EventArgs e)
        {
            FormLiquidacao liquidacao = new FormLiquidacao();
            liquidacao.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
