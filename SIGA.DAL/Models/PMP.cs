using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class PMP
    {
        public PMP()
        {
            this.ItensPMP = new List<ItemPMP>();
            this.LocaisPMP = new List<LocalInstalacaoPMP>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ItemPMP> ItensPMP { get; set; }
        public virtual ICollection<LocalInstalacaoPMP> LocaisPMP { get; set; }
    }
}
