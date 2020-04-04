using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Usina
    {
        public Usina()
        {
            this.Locais = new List<LocalInstalacao>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public decimal? EmpresaID { get; set; }
        public string SiteID { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Site Site { get; set; }
        public virtual ICollection<LocalInstalacao> Locais { get; set; }
    }
}
