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

namespace CrediBlaster.Forms
{
    public partial class Processamento : Form
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
        TelaProcessamentoService tps = new TelaProcessamentoService();
        

        private void textBoxDataAtual_TextChanged(object sender, EventArgs e)
        {
            

        }        


        // textBoxNumeroContrato.Text = nrCtr.ToString();


        public Processamento()
        {
            InitializeComponent();
            
            this.Paint += new PaintEventHandler(set_background);
            // janela iniciar maximizada  
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja iniciar processamento? ","Cancelar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                tps.IniciaProcessamento();          

            };
               
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }      

        private void Processamento_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            //Traz as informações de abrangência em tela
            Abrangencia abrangencia = new Abrangencia();
            AgenciaDTO agencia = new AgenciaDTO();

            agencia = abrangencia.buscaAgencia();

            textBoxEmpresa.Text = agencia.empresa.ToString();
            textBoxUnidade.Text = agencia.unidade.ToString();
            textBoxDescrAgencia.Text = agencia.descricaoAgencia.ToString();
            textBoxDataAtual.Text = agencia.dataAtual.ToString("dd/MM/yyyy");


        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Efeito degradê
            this.Paint += new PaintEventHandler(set_background);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Efeito degradê
            this.Paint += new PaintEventHandler(set_background);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
