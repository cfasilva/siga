using System;
using System.Collections.Generic;

namespace SIGA.DAL
{
    public partial class ItemFMEA
    {
        public decimal ID { get; set; }
        public string FMEAID { get; set; }
        public string TarefaID { get; set; }
        public string Funcao { get; set; }
        public string Falha { get; set; }
        public string Modo { get; set; }
        public string Causa { get; set; }
        public string Efeito { get; set; }
        public decimal? DcrS { get; set; }
        public decimal? DcrO { get; set; }
        public decimal? DcrD { get; set; }
        public decimal? DcrNPR { get; set; }
        public string GrauRisco { get; set; }
        public string Decisao { get; set; }
        public string DcrP1 { get; set; }
        public string DcrP2 { get; set; }
        public string DcrP3 { get; set; }
        public string DcrP4 { get; set; }
        public string DcrP5 { get; set; }
        public string DcrP6 { get; set; }
        public string Acao { get; set; }
        public string Detalhe { get; set; }
        public virtual FMEA FMEA { get; set; }
        public virtual Tarefa Tarefa { get; set; }
    }
}
