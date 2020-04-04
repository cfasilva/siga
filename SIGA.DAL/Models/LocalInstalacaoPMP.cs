using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class LocalInstalacaoPMP
    {
        public decimal ID { get; set; }
        public string Tag { get; set; }
        public string PMPID { get; set; }
        public virtual PMP PMP { get; set; }
        public virtual LocalInstalacao LocalInstalacao { get; set; }
    }
}
