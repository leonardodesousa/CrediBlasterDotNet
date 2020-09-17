using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediBlaster
{
    class ParcelasDTO
    {
        public long NrPrc {  get; }
        public decimal TxJur {  get; }
        public decimal VrJur {  get; }
        public decimal VrPrc {  get; }
        public decimal VrTotPrc {  get; }
        public DateTime DtVenc {  get; }

        public ParcelasDTO()
        {
            //construtor default
        }

        public ParcelasDTO(long nrPrc, decimal txJur, decimal vrJur, decimal vrPrc, decimal vrTotPrc, DateTime dtVenc)
        {
            this.NrPrc = nrPrc;
            this.TxJur = txJur;
            this.VrJur = vrJur;
            this.VrPrc = vrPrc;
            this.VrTotPrc = vrTotPrc;
            this.DtVenc = dtVenc;
        }
    }
}
