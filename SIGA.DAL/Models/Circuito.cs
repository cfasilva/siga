using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Circuito
    {
        public Circuito()
        {
            this.Itens = new List<ItemCircuito>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ItemCircuito> Itens { get; set; }
    }
}
