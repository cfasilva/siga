using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class ItemPMPMap : EntityTypeConfiguration<ItemPMP>
    {
        public ItemPMPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PMPID)
                .HasMaxLength(12);

            this.Property(t => t.TipoManutencaoID)
                .HasMaxLength(12);

            this.Property(t => t.TipoPeriodoID)
                .HasMaxLength(12);

            this.Property(t => t.EspecialidadeID)
                .HasMaxLength(12);

            this.Property(t => t.FMEAID)
                .HasMaxLength(12);

            this.Property(t => t.TarefaID)
                .HasMaxLength(12);

            this.Property(t => t.CondicaoExecucao)
                .HasMaxLength(8);

            this.Property(t => t.Turma)
                .HasMaxLength(32);

            this.Property(t => t.Procedimento)
                .HasMaxLength(1);

            this.Property(t => t.DescTarefa)
                .HasMaxLength(128);

            this.Property(t => t.Componente)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ITEMPMP");
            this.Property(t => t.ID).HasColumnName("COD_ITEMPMP");
            this.Property(t => t.PMPID).HasColumnName("COD_PMP");
            this.Property(t => t.TipoManutencaoID).HasColumnName("COD_TIPOMANUT");
            this.Property(t => t.TipoPeriodoID).HasColumnName("COD_TIPOPERIODO");
            this.Property(t => t.EspecialidadeID).HasColumnName("COD_ESPECIALIDADE");
            this.Property(t => t.FMEAID).HasColumnName("COD_FMEA");
            this.Property(t => t.TarefaID).HasColumnName("COD_TAREFA");
            this.Property(t => t.CondicaoExecucao).HasColumnName("DCR_CONDEXEC");
            this.Property(t => t.Periodo).HasColumnName("INT_PERIODO");
            this.Property(t => t.Duracao).HasColumnName("INT_DURACAO");
            this.Property(t => t.Quantidade).HasColumnName("INT_QUANTIDADE");
            this.Property(t => t.Turma).HasColumnName("DCR_TURMAEXEC");
            this.Property(t => t.Procedimento).HasColumnName("DCR_PROCEDIMENTO");
            this.Property(t => t.DescTarefa).HasColumnName("DCR_TAREFA");
            this.Property(t => t.Componente).HasColumnName("DCR_COMPONENTE");

            // Relationships
            this.HasOptional(t => t.Especialidade)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.EspecialidadeID);
            this.HasOptional(t => t.FMEA)
                .WithMany(t => t.ItensPMP)
                .HasForeignKey(d => d.FMEAID);
            this.HasOptional(t => t.PMP)
                .WithMany(t => t.ItensPMP)
                .HasForeignKey(d => d.PMPID);
            this.HasOptional(t => t.TipoManutencao)
                .WithMany(t => t.ItensPMP)
                .HasForeignKey(d => d.TipoManutencaoID);
            this.HasOptional(t => t.TipoPeriodo)
                .WithMany(t => t.ItensPMP)
                .HasForeignKey(d => d.TipoPeriodoID);
            this.HasOptional(t => t.Tarefa)
                .WithMany(t => t.ItensPMP)
                .HasForeignKey(d => d.TarefaID);

        }
    }
}
