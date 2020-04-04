using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class LocalInstalacaoFMEA
    {
        public decimal ID { get; set; }
        public string Tag { get; set; }
        public string FMEAID { get; set; }
        public virtual FMEA FMEA { get; set; }
        public virtual LocalInstalacao LocalInstalacao { get; set; }
    }
}
