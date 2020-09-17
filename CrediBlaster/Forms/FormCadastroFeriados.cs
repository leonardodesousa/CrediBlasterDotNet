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

namespace CrediBlaster.Forms
{
    public partial class FormCadastroFeriados : Form
    {
        public FormCadastroFeriados()
        {
            InitializeComponent();

            //monthCalendar1.SelectionRange.Start.ToShortDateString();
            
        }

        private void DescricaoFeriadoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxDataSelecionada.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
          

        private void textBoxDescricaoFeriado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataSelecionada_TextChanged(object sender, EventArgs e)
        {


        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            TelaParametrosService tps = new TelaParametrosService();
            //String descricao = textBoxDescricaoFeriado.ToString();
            DateTime data = DateTime.Parse(textBoxDataSelecionada.Text);
            tps.cadastraFeriado(textBoxDescricaoFeriado.Text.ToString(), data);
        }
    }
}
