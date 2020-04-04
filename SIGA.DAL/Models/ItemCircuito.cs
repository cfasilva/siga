using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class ItemCircuito
    {
        public decimal ID { get; set; }
        public string CircuitoID { get; set; }
        public string Tag { get; set; }
        public virtual Circuito Circuito { get; set; }
        public virtual LocalInstalacao Local { get; set; }
    }
}
