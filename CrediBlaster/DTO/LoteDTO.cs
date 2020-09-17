using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster
{
    class LoteDTO
    {
        public long lote { set; get;  }
        public long contrato { set; get;  }
        public long cliente { set; get;  }
        public String tipoLote { set; get;  }
        public decimal valor { set; get;  }
        public String interfaceOrigem { set; get;  }
        public String situacao { set; get;  }

        public LoteDTO(long lote, long contrato, long cliente, string tipoLote, decimal valor, string interfaceOrigem, string situacao)
        {
            this.lote = lote;
            this.contrato = contrato;
            this.cliente = cliente;
            this.tipoLote = tipoLote;
            this.valor = valor;
            this.interfaceOrigem = interfaceOrigem;
            this.situacao = situacao;
        }

        public LoteDTO()
        {
        }
    }
}
