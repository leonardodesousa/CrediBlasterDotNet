using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrediBlaster
{
    public partial class FormEfetivaLotes : Form
    {
        public FormEfetivaLotes()
        {
            InitializeComponent();
        }       

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<LoteDTO> lista = new List<LoteDTO>();
            //TelaContratosServices tcs = new TelaContratosServices();
            TelaEfetivaLotesServices tes = new TelaEfetivaLotesServices();

            lista = tes.buscaLotes();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            int cont = 0;

            treeView1.Nodes.Add("Lotes");
            while (cont < lista.Count)
            {
                treeView1.Nodes[0].Nodes.Add(lista.ElementAt(cont).lote.ToString());
                treeView1.Nodes[0].Nodes[cont].Nodes.Add(lista.ElementAt(cont).valor.ToString("C") /*+ " - " +
                   " Contrato " + lista.ElementAt(cont).Contrato*/);
                cont++;
            }
            treeView1.EndUpdate();
        }

        private void FormEfetivaLotes_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String selectedNodeText = e.Node.Text;
            textBoxLoteSelecionado.Text = selectedNodeText;
            String loteSelecionado = selectedNodeText;

            //String selectedNodeText = e.Node.Text;
            //textBoxCtrSelecionado.Text = selectedNodeText;

            //String contratoSeleciona = selectedNodeText;
        }

        private void textBoxLoteSelecionado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEfetivaLote_Click(object sender, EventArgs e)
        {
            TelaEfetivaLotesServices tfs = new TelaEfetivaLotesServices();

            long lote = Convert.ToInt64(textBoxLoteSelecionado.Text);
            tfs.efetvaLoteLiquidacao(lote, "LIQ");

            List<LoteDTO> lista = new List<LoteDTO>();
            //TelaContratosServices tcs = new TelaContratosServices();
            TelaEfetivaLotesServices tes = new TelaEfetivaLotesServices();

            lista = tes.buscaLotes();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            int cont = 0;

            treeView1.Nodes.Add("Lotes");
            while (cont < lista.Count)
            {
                treeView1.Nodes[0].Nodes.Add(lista.ElementAt(cont).lote.ToString());
                treeView1.Nodes[0].Nodes[cont].Nodes.Add(lista.ElementAt(cont).valor.ToString("C") + " - " +
                   " Contrato " + lista.ElementAt(cont).contrato);
                cont++;
            }
            treeView1.EndUpdate();

            textBoxLoteSelecionado.Text = " ";

        }
    }
}
