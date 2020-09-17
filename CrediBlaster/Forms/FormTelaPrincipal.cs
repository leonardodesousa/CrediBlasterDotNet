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
using CrediBlaster.Forms;


namespace CrediBlaster
{
    public partial class FormTelaPrincipal : Form
    {
        private void set_background(Object sender, PaintEventArgs e)
        {
            // Carregar imagem como plano de fundo da janela 
            /*
            BackgroundImage = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\Imagens\finances.jpg");
                */
            //Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            //Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            //Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);

            //apply gradient         
            //graphics.FillRectangle(b, gradient_rectangle);
        }
        public FormTelaPrincipal()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            //FormBorderStyle = FormBorderStyle.None;
            // WindowState = FormWindowState.Maximized;
            //this.Location = new Point(0, 0);
            // this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void buttonLiquidar_Click(object sender, EventArgs e)
        {
            FormLiquidacao liquidacao = new FormLiquidacao();
            liquidacao.Show();
        }

        private void buttonNovaOper_Click(object sender, EventArgs e)
        {
            FormOperacoesCredito OperCredi = new FormOperacoesCredito();
            OperCredi.Show();
        }

        private void buttonMovimento_Click(object sender, EventArgs e)
        {
            FormContratos contratos = new FormContratos();
            contratos.Show();
            
        }

        private void buttonMovimentoLotes_Click(object sender, EventArgs e)
        {
            FormEfetivaLotes efetvaLotes = new FormEfetivaLotes();
            efetvaLotes.Show();
            
            //FormOperacoesCredito OperCredi = new FormOperacoesCredito();
            //OperCredi.Show();
        }

        private void buttonProcessamento_Click(object sender, EventArgs e)
        {
            Processamento processamento = new Processamento();
            processamento.Show();
        }

        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarFeriadosButton_Click(object sender, EventArgs e)
        {
            FormCadastroFeriados cadastroFeriados = new FormCadastroFeriados();
            cadastroFeriados.Show();
        }
    }
}
