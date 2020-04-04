using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Empresa
    {
        public Empresa()
        {
            this.Usinas = new List<Usina>();
        }

        public decimal ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Usina> Usinas { get; set; }
    }
}
