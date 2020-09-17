using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster.Model
{
    class Contrato
    {
        public long cdCli { get; set; }
        public String nomeCli { get; set; }
        public long nrContrato { get; set; }
        public long nrParcela { get; set; }
        public DateTime dtInc { get; set; }
        public long qtParcelas { get; set; }
        public long nrCtr { get; set; }
        public long cic { get; set; }
        public decimal txJuros { get; set; }
        public decimal valorJuros { get; set; }
        public long carencia { get; set; }
        public decimal valorOriginal { get; set; }
        public decimal valorTotal { get; set; }
        public String idSit { get; set; }
        public DateTime dtVenc { get; set; }
        public decimal prazoTotal { get; set; }

           
        public Contrato(long cdCli, string nomeCli, long nrContrato, long nrParcela, DateTime dtInc, long qtParcelas, long nrCtr, 
            long cic, decimal txJuros, decimal valorJuros, long carencia, decimal valorOriginal, decimal valorTotal, string idSit, DateTime qtVenc, decimal prazoTotal)
        {
            this.cdCli = cdCli;
            this.nomeCli = nomeCli;
            this.nrContrato = nrContrato;
            this.nrParcela = nrParcela;
            this.dtInc = dtInc;
            this.qtParcelas = qtParcelas;
            this.nrCtr = nrCtr;
            this.cic = cic;
            this.txJuros = txJuros;
            this.valorJuros = valorJuros;
            this.carencia = carencia;
            this.valorOriginal = valorOriginal;
            this.valorTotal = valorTotal;
            this.idSit = idSit;
            this.dtVenc = qtVenc;
            this.prazoTotal = prazoTotal;
        }
        
        

        public Contrato()
        {
            
        }

    }
}
