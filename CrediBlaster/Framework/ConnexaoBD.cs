using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster
{
    class ConnexaoBD
    {
        public String conecta(String banco)
        {
            String conexao;
            StringBuilder sb = new StringBuilder();
            if (banco == "oracle")
            {
                sb.Append("Data Source=(DESCRIPTION=");
                sb.Append("(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.158.145)(PORT=1521)))");
                sb.Append("(CONNECT_DATA=(SID=CDB2)));");
                sb.Append("User Id=CREDIBLASTER;Password=CREDIBLASTER;");
                conexao = sb.ToString();
                return conexao;
            }
            else if (banco == "sqlserver")
            {
                conexao = "Data Source=DESKTOP-N20KA03\\SQL2017;Initial Catalog=crediBlaster;" +
                               "User ID=sa;Password=sa;Language=Portuguese";
                //SqlConnection conexao = new SqlConnection(conec);
                return conexao;               
            }



            else
            {
                System.Windows.Forms.MessageBox.Show("Conexão não suportada!");
                conexao = "";
                return conexao;
            }
            

        }
    }
}
