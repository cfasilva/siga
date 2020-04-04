using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class TipoManutencao
    {
        public TipoManutencao()
        {
            this.ItensPMP = new List<ItemPMP>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ItemPMP> ItensPMP { get; set; }
    }
}
