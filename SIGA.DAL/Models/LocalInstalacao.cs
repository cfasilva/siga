using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class LocalInstalacao
    {
        public LocalInstalacao()
        {
            this.ItensCircuito = new List<ItemCircuito>();
            this.ItensLocalPMP = new List<ItemLocalPMP>();
            this.LocaisFMEA = new List<LocalInstalacaoFMEA>();
            this.LocaisPMP = new List<LocalInstalacaoPMP>();
        }

        public string Tag { get; set; }
        public string DisciplinaID { get; set; }
        public string FamiliaID { get; set; }
        public string SiteID { get; set; }
        public string ProcessoID { get; set; }
        public string UsinaID { get; set; }
        public string SubSistema { get; set; }
        public string TagPai { get; set; }
        public string Critico { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Familia Familia { get; set; }
        public virtual Site Site { get; set; }
        public virtual Processo Processo { get; set; }
        public virtual Usina Usina { get; set; }
        public virtual ICollection<ItemCircuito> ItensCircuito { get; set; }
        public virtual ICollection<ItemLocalPMP> ItensLocalPMP { get; set; }
        public virtual ICollection<LocalInstalacaoFMEA> LocaisFMEA { get; set; }
        public virtual ICollection<LocalInstalacaoPMP> LocaisPMP { get; set; }
    }
}