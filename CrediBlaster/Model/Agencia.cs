using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster.Model
{
    class Agencia
    {
        public int unidade { get; set; }
        public int empresa { get; set; }
        public String descricaoAgencia { get; set; }
        public DateTime dataAtual { get; set; }
        public Boolean processamentoIniciado { get; set; }

        public Agencia(int unidade, int empresa, string descricaoAgencia, DateTime dataAtual, bool processamentoIniciado)
        {
            this.unidade = unidade;
            this.empresa = empresa;
            this.descricaoAgencia = descricaoAgencia;
            this.dataAtual = dataAtual;
            this.processamentoIniciado = processamentoIniciado;
        }

        public Agencia()
        {

        }
    }
}
