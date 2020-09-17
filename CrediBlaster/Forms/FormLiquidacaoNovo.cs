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
    public partial class FormLiquidacaoNovo : Form
    {
        public FormLiquidacaoNovo()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String x = "Teste";
            x = checkedListBox1.Items[0].ToString();
        }

        private void FormLiquidacaoNovo_Load(object sender, EventArgs e)
        {

        }
    }
}
