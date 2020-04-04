using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class FMEA
    {
        public FMEA()
        {
            this.ItensFMEA = new List<ItemFMEA>();
            this.ItensPMP = new List<ItemPMP>();
            this.Locais = new List<LocalInstalacaoFMEA>();
        }

        public string ID { get; set; }
        public string SiteID { get; set; }
        public string FamiliaID { get; set; }
        public string Descricao { get; set; }
        public virtual Site Site { get; set; }
        public virtual Familia Familia { get; set; }
        public virtual ICollection<ItemFMEA> ItensFMEA { get; set; }
        public virtual ICollection<ItemPMP> ItensPMP { get; set; }
        public virtual ICollection<LocalInstalacaoFMEA> Locais { get; set; }
    }
}
