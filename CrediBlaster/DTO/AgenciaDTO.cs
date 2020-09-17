using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrediBlaster.Model;


namespace CrediBlaster.DTO
{
    class AgenciaDTO
    {
        public int unidade { get; }
        public int empresa { get; }
        public String descricaoAgencia { get; }
        public DateTime dataAtual { get; }
        public Boolean processamentoIniciado { get; }

        public AgenciaDTO(Agencia agencia)
        {
            this.unidade = agencia.unidade;
            this.empresa = agencia.empresa;
            this.descricaoAgencia = agencia.descricaoAgencia;
            this.dataAtual = agencia.dataAtual;
            this.processamentoIniciado = agencia.processamentoIniciado;
        }

        public AgenciaDTO()
        {
        }
    }
}
