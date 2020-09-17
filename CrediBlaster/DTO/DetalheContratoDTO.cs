using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrediBlaster.Model;


namespace CrediBlaster.DTO
{
    class DetalheContratoDTO
    {
        public long cdCli { get; }
        public String nomeCli { get; }
        public long nrParcela { get; }
        public DateTime dtInc  { get; }
        public long qtParcelas { get;  }
        public long nrCtr { get; }
        public long cic { get; }
        public decimal txJuros { get; }
        public decimal valorJuros { get; }
        public long carencia { get; }
        public decimal valorOriginal { get; }
        public decimal valorTotal { get; }
        public String idSit { get; }
        public DateTime dtVenc { get; }
        public decimal prazoTotal { get; }

        
       

        public DetalheContratoDTO(Contrato contrato)
        {
            this.cdCli = contrato.cdCli;
            this.nomeCli = contrato.nomeCli;
            this.nrParcela = contrato.nrParcela;
            this.dtInc = contrato.dtInc;
            this.qtParcelas = contrato.qtParcelas;
            this.nrCtr = contrato.nrCtr;
            this.cic = contrato.cic;
            this.txJuros = contrato.txJuros;
            this.valorJuros = contrato.valorJuros;
            this.carencia = contrato.carencia;
            this.valorOriginal = contrato.valorOriginal;
            this.valorTotal = contrato.valorTotal;
            this.idSit = contrato.idSit;
            this.dtVenc = contrato.dtVenc;
            this.prazoTotal = contrato.prazoTotal;
        }

        public DetalheContratoDTO()
        {

        }
    }
}
