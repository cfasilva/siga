using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Familia
    {
        public Familia()
        {
            this.FMEAs = new List<FMEA>();
            this.Locais = new List<LocalInstalacao>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<FMEA> FMEAs { get; set; }
        public virtual ICollection<LocalInstalacao> Locais { get; set; }
    }
}
