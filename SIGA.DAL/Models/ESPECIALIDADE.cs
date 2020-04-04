using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            this.Itens = new List<ItemPMP>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ItemPMP> Itens { get; set; }
    }
}
