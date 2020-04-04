using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class ItemPMP
    {
        public ItemPMP()
        {
            this.Itens = new List<ItemLocalPMP>();
        }

        public decimal ID { get; set; }
        public string EspecialidadeID { get; set; }
        public string FMEAID { get; set; }
        public string PMPID { get; set; }
        public string TipoManutencaoID { get; set; }
        public string TipoPeriodoID { get; set; }
        public string TarefaID { get; set; }
        public string CondicaoExecucao { get; set; }
        public decimal? Periodo { get; set; }
        public decimal? Duracao { get; set; }
        public decimal? Quantidade { get; set; }
        public string Turma { get; set; }
        public string Procedimento { get; set; }
        public string DescTarefa { get; set; }
        public string Componente { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public virtual FMEA FMEA { get; set; }
        public virtual PMP PMP { get; set; }
        public virtual TipoManutencao TipoManutencao { get; set; }
        public virtual TipoPeriodo TipoPeriodo { get; set; }
        public virtual Tarefa Tarefa { get; set; }

        public virtual ICollection<ItemLocalPMP> Itens { get; set; }
    }
}
