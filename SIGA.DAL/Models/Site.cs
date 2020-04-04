using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Site
    {
        public Site()
        {
            this.FMEAs = new List<FMEA>();
            this.Locais = new List<LocalInstalacao>();
            this.Usinas = new List<Usina>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<FMEA> FMEAs { get; set; }
        public virtual ICollection<LocalInstalacao> Locais { get; set; }
        public virtual ICollection<Usina> Usinas { get; set; }
    }
}
