using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SIGA.DAL
{
    public partial class SigaContext : DbContext
    {
        static SigaContext()
        {
            Database.SetInitializer<SigaContext>(new Configuration());
        }

        public SigaContext()
            : base("Name=SIGA_DBContext")
        {
        }

        public DbSet<Circuito> Circuitos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<FMEA> FMEAs { get; set; }
        public DbSet<PMP> PMPs { get; set; }
        public DbSet<ItemCircuito> ItensCircuito { get; set; }
        public DbSet<ItemFMEA> ItensFMEA { get; set; }
        public DbSet<ItemPMP> ItensPMP { get; set; }
        public DbSet<ItemLocalPMP> ItensLocalPMP { get; set; }
        public DbSet<LocalInstalacao> Locais { get; set; }
        public DbSet<LocalInstalacaoFMEA> LocaisFMEA { get; set; }
        public DbSet<LocalInstalacaoPMP> LocaisPMP { get; set; }
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoManutencao> TipoManutencoes { get; set; }
        public DbSet<TipoPeriodo> TipoPeriodos { get; set; }
        public DbSet<Usina> Usinas { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Prevents table names from being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Remove unused conventions
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CircuitoMap());
            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new EmpresaMap());
            modelBuilder.Configurations.Add(new EspecialidadeMap());
            modelBuilder.Configurations.Add(new FamiliaMap());
            modelBuilder.Configurations.Add(new FMEAMap());
            modelBuilder.Configurations.Add(new ItemCircuitoMap());
            modelBuilder.Configurations.Add(new ItemFMEAMap());
            modelBuilder.Configurations.Add(new ItemLocalPMPMap());
            modelBuilder.Configurations.Add(new ItemPMPMap());
            modelBuilder.Configurations.Add(new LocalInstalacaoMap());
            modelBuilder.Configurations.Add(new LocalInstalacaoFMEAMap());
            modelBuilder.Configurations.Add(new LocalInstalacaoPMPMap());
            modelBuilder.Configurations.Add(new PMPMap());
            modelBuilder.Configurations.Add(new ProcessoMap());
            modelBuilder.Configurations.Add(new SiteMap());
            modelBuilder.Configurations.Add(new TarefaMap());
            modelBuilder.Configurations.Add(new TipoManutencaoMap());
            modelBuilder.Configurations.Add(new TipoPeriodoMap());
            modelBuilder.Configurations.Add(new UsinaMap());
        }
    }
}
