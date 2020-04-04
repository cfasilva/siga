namespace SIGA.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DropCreateDatabaseIfModelChanges<SigaContext>
    {
        protected override void Seed(SigaContext context)
        {
            context.Circuitos.AddOrUpdate(
                x => x.Descricao,
                new Circuito { ID = "CIRC 7P6ATC", Descricao = "CIRCUITO TRANSP CORREIA 7P6ATC" },
                new Circuito { ID = "CIRC 1PA11RF", Descricao = "CIRCUITO DO 1PA11RF" },
                new Circuito { ID = "CIRC 1PA12TC", Descricao = "CIRCUITO DO 1PA12TC" },
                new Circuito { ID = "CIRC 1PR4ASI", Descricao = "CIRCUITO DO 1PR4ASI" },
                new Circuito { ID = "CIRC 1PR5ATC", Descricao = "CIRCUITO DO 1PR5ATC" },
                new Circuito { ID = "CIRC 1PR5BTC", Descricao = "CIRCUITO DO 1PR5BTC" },
                new Circuito { ID = "CIRC 1PA5TC", Descricao = "CIRCUITO DO 1PA5TC" },
                new Circuito { ID = "CIRC 3PA60LV", Descricao = "CIRCUITO DO 3PA60LV" },
                new Circuito { ID = "CIRC 3PA5RF", Descricao = "CIRCUITO DO 3PA5RF" },
                new Circuito { ID = "CIRC 3PA6HO", Descricao = "CIRCUITO DO 3PA6HO" },
                new Circuito { ID = "CIRC 4PA5RF", Descricao = "CIRCUITO DO 4PA5RF" },
                new Circuito { ID = "CIRC 4PA6HO", Descricao = "CIRCUITO DO 4PA6HO" },
                new Circuito { ID = "CIRC 5PA60LP", Descricao = "CIRCUITO DO 5PA60LP" },
                new Circuito { ID = "CIRC 5PA5RF", Descricao = "CIRCUITO DO 5PA5RF" },
                new Circuito { ID = "CIRC 5PA6TC", Descricao = "CIRCUITO DO 5PA6TC" },
                new Circuito { ID = "CIRC 5PA6ACH", Descricao = "CIRCUITO DO 5PA6ACH" },
                new Circuito { ID = "CIRC 5PA6BCH", Descricao = "CIRCUITO DO 5PA6BCH" }
            );

            context.Processos.AddOrUpdate(
                x => x.Descricao,
                new Processo { ID = "ALI", Descricao = "ALIMENTACAO" },
                new Processo { ID = "AUT", Descricao = "AUTOMACAO" },
                new Processo { ID = "ESP", Descricao = "ESPESSAMENTO E HOMOGENEIZACAO" },
                new Processo { ID = "FIL", Descricao = "FILTRAGEM" },
                new Processo { ID = "INS", Descricao = "INSTALACOES INDUSTRIAIS" },
                new Processo { ID = "MIS", Descricao = "MISTURA" },
                new Processo { ID = "MOA", Descricao = "MOAGEM" },
                new Processo { ID = "PAM", Descricao = "PROTECAO AMBIENTAL" },
                new Processo { ID = "PEL", Descricao = "PELOTAMENTO" },
                new Processo { ID = "PEN", Descricao = "PENEIRAMENTO" },
                new Processo { ID = "PFI", Descricao = "PATIO DE FINOS" },
                new Processo { ID = "PRE", Descricao = "PRENSAGEM" },
                new Processo { ID = "QUE", Descricao = "QUEIMA" },
                new Processo { ID = "SAL", Descricao = "SALA DE CONTROLE" },
                new Processo { ID = "SUB", Descricao = "SUBESTACOES / SALAS ELETRICAS" }
            );

            context.Usinas.AddOrUpdate(
                x => x.Descricao,
                new Usina { ID = "US01", Descricao = "Usina 1" },
                new Usina { ID = "US02", Descricao = "Usina 2" },
                new Usina { ID = "US03", Descricao = "Usina 3" }
            );

            context.Disciplinas.AddOrUpdate(
                x => x.Descricao,
                new Disciplina { ID = "MEC", Descricao = "MECÂNICA" },
                new Disciplina { ID = "ELE", Descricao = "ELÉTRICA" },
                new Disciplina { ID = "INST", Descricao = "INSTRUMENTAÇÃO" }
            );

            context.Sites.AddOrUpdate(
                x => x.Descricao,
                new Site { ID = "PEVT", Descricao = "PELOTIZAÇÃO VITÓRIA" },
                new Site { ID = "PEVG", Descricao = "PELOTIZAÇÃO VARGEM GRANDE" },
                new Site { ID = "PECG", Descricao = "PELOTIZAÇÃO CONGONHAS" }
            );

            context.Especialidades.AddOrUpdate(
                x => x.Descricao,
                new Especialidade { ID = "CAC", Descricao = "CALDEREIRO" },
                new Especialidade { ID = "ELC", Descricao = "ELETRICISTA" },
                new Especialidade { ID = "INC", Descricao = "INSTRUMENTISTA" },
                new Especialidade { ID = "LBC", Descricao = "LUBRIFICADOR" },
                new Especialidade { ID = "MEC", Descricao = "MECÂNICO" },
                new Especialidade { ID = "OPC", Descricao = "OPERADOR" },
                new Especialidade { ID = "SOC", Descricao = "SOLDADOR" },
                new Especialidade { ID = "TEC", Descricao = "TÉCNICO" },
                new Especialidade { ID = "VUC", Descricao = "VULCANIZADOR" }
            );

            context.Tarefas.AddOrUpdate(
                x => x.Descricao,
                new Tarefa { ID = "TRP", Descricao = "TAREFA DE RESTAURAÇÃO PROGRAMADA" },
                new Tarefa { ID = "TDP", Descricao = "TAREFA DE DESCARTE PROGRAMADO" },
                new Tarefa { ID = "TBFP", Descricao = "TAREFA DE BUSCA DE FALHA PROGRAMADA" },
                new Tarefa { ID = "CBT", Descricao = "COMBINAÇÃO DE TAREFAS" },
                new Tarefa { ID = "RPJ", Descricao = "REPROJETO" },
                new Tarefa { ID = "NMP", Descricao = "NENHUMA MANUTENÇÃO PROGRAMADA" },
                new Tarefa { ID = "MHL", Descricao = "MELHORIA" },
                new Tarefa { ID = "TSP", Descricao = "TAREFA SOBCONDIÇÃO PROGRAMADA" }
            );

            context.TipoManutencoes.AddOrUpdate(
                x => x.Descricao,
                new TipoManutencao { ID = "AC", Descricao = "AFERIÇÃO / CALIBRAÇÃO" },
                new TipoManutencao { ID = "CP", Descricao = "MANUTENÇÃO CORRETIVA PROGRAMAD" },
                new TipoManutencao { ID = "IE", Descricao = "INSPEÇÃO ELETRICA" },
                new TipoManutencao { ID = "II", Descricao = "INSPEÇÃO INSTRUMENTACAO" },
                new TipoManutencao { ID = "IM", Descricao = "INSPEÇÃO MECANICA" },
                new TipoManutencao { ID = "IP", Descricao = "INSPEÇÃO PREDITIVA" },
                new TipoManutencao { ID = "MC", Descricao = "MANUTENÇÃO CORRETIVA DE EMERGE" },
                new TipoManutencao { ID = "MM", Descricao = "MANUTENÇÃO DE MELHORIA" },
                new TipoManutencao { ID = "MP", Descricao = "MANUTENÇÃO PREVENTIVA SISTEMÁTICA" },
                new TipoManutencao { ID = "PC", Descricao = "MANUTENÇÃO CONDICIONAL" },
                new TipoManutencao { ID = "RR", Descricao = "REFORMAS / RECUPERAÇÕES" },
                new TipoManutencao { ID = "SA", Descricao = "SERVIÇO DE APOIO" },
                new TipoManutencao { ID = "IO", Descricao = "INSPEÇÃO OPERAÇÃO" }
            );

            context.TipoPeriodos.AddOrUpdate(
                x => x.Descricao,
                new TipoPeriodo { ID = "HOR", Descricao = "HORA" },
                new TipoPeriodo { ID = "DIA", Descricao = "DIA" },
                new TipoPeriodo { ID = "SEM", Descricao = "SEMANA" },
                new TipoPeriodo { ID = "MES", Descricao = "MÊS" },
                new TipoPeriodo { ID = "ANO", Descricao = "ANO" }
            );

            context.PMPs.AddOrUpdate(
                x => x.Descricao,
                new PMP { ID = "VTMTCP001", Descricao = "TC_ CPESO CARRO-MOTRED_ACOPL" },
                new PMP { ID = "VTMRUP034", Descricao = "TC-MOTOREDUTOR (CRITICIDADE 1-2)" },
                new PMP { ID = "VTMRAP003", Descricao = "TC-RASPADOR_01-02SEM" },
                new PMP { ID = "VTMTJP007", Descricao = "TC-TAMBOR_ACION MONT VIBR" },
                new PMP { ID = "VTMTJP010", Descricao = "TC-TAMBORES_RET DESVIO MONT VIBR" },
                new PMP { ID = "VTEPNP019", Descricao = "RCM - ELE - PAINEL DE COMANDO LOCAL 48 - 2 SEM" },
                new PMP { ID = "VTECEP008", Descricao = "RCM - ELE - CHAVE LIMITE DE EMERGENCIA 48-2 SEM" },
                new PMP { ID = "VTECJP008", Descricao = "RCM - ELE -CHAVE LIMITE DE DESALINHAMENTO 48-2 SEM" },
                new PMP { ID = "VTEMTP047", Descricao = "RCM - ELE - MOTOR BT 48 - 2 SEM 8" }
            );

            context.SaveChanges();
        }
    }
}