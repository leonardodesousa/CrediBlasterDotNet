using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster.Model
{
    class Lote
    {
        public long lote { get; set; }
        public long contrato { get; set; }
        public long cliente { get; set; }
        public String tipoLote { get; set; }
        public decimal valor { get; set; }
        public String interfaceOrigem { get; set; }
        public String situacao { get; set; }

        public Lote(long lote, long contrato, long cliente, string tipoLote, decimal valor, string interfaceOrigem, string situacao)
        {
            this.lote = lote;
            this.contrato = contrato;
            this.cliente = cliente;
            this.tipoLote = tipoLote;
            this.valor = valor;
            this.interfaceOrigem = interfaceOrigem;
            this.situacao = situacao;
        }
    }


}
