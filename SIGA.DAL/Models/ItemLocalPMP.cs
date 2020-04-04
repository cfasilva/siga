using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class ItemLocalPMP
    {
        public decimal ID { get; set; }
        public string Tag { get; set; }
        public decimal? ItemID { get; set; }
        public decimal? SemanaInicio { get; set; }
        public decimal Periodo { get; set; }
        public decimal PeriodoEquipa { get; set; }
        public decimal PeriodoCircuito { get; set; }
        public virtual LocalInstalacao Local { get; set; }
        public virtual ItemPMP Item { get; set; }
    }
}
