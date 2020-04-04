using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class Processo
    {
        public Processo()
        {
            this.Locais = new List<LocalInstalacao>();
        }

        public string ID { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<LocalInstalacao> Locais { get; set; }
    }
}
