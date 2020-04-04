using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class ItemFMEAMap : EntityTypeConfiguration<ItemFMEA>
    {
        public ItemFMEAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FMEAID)
                .HasMaxLength(12);

            this.Property(t => t.TarefaID)
                .HasMaxLength(12);

            this.Property(t => t.Funcao)
                .HasMaxLength(128);

            this.Property(t => t.Falha)
                .HasMaxLength(128);

            this.Property(t => t.Modo)
                .HasMaxLength(128);

            this.Property(t => t.Causa)
                .HasMaxLength(128);

            this.Property(t => t.Efeito)
                .HasMaxLength(128);

            this.Property(t => t.GrauRisco)
                .HasMaxLength(8);

            this.Property(t => t.Decisao)
                .HasMaxLength(1);

            this.Property(t => t.DcrP1)
                .HasMaxLength(1);

            this.Property(t => t.DcrP2)
                .HasMaxLength(1);

            this.Property(t => t.DcrP3)
                .HasMaxLength(1);

            this.Property(t => t.DcrP4)
                .HasMaxLength(1);

            this.Property(t => t.DcrP5)
                .HasMaxLength(1);

            this.Property(t => t.DcrP6)
                .HasMaxLength(1);

            this.Property(t => t.Acao)
                .HasMaxLength(128);

            this.Property(t => t.Detalhe)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ITEMFMEA");
            this.Property(t => t.ID).HasColumnName("COD_ITEMFMEA");
            this.Property(t => t.FMEAID).HasColumnName("COD_FMEA");
            this.Property(t => t.TarefaID).HasColumnName("COD_TAREFA");
            this.Property(t => t.Funcao).HasColumnName("DCR_FUNCAO");
            this.Property(t => t.Falha).HasColumnName("DCR_FALHAFUNC");
            this.Property(t => t.Modo).HasColumnName("DCR_MODOFALHA");
            this.Property(t => t.Causa).HasColumnName("DCR_CAUSAFALHA");
            this.Property(t => t.Efeito).HasColumnName("DCR_EFEITOFALHA");
            this.Property(t => t.DcrS).HasColumnName("DCR_S");
            this.Property(t => t.DcrO).HasColumnName("DCR_O");
            this.Property(t => t.DcrD).HasColumnName("DCR_D");
            this.Property(t => t.DcrNPR).HasColumnName("DCR_NPR");
            this.Property(t => t.GrauRisco).HasColumnName("DCR_GRAURISCO");
            this.Property(t => t.Decisao).HasColumnName("DCR_DECISAO");
            this.Property(t => t.DcrP1).HasColumnName("DCR_P1");
            this.Property(t => t.DcrP2).HasColumnName("DCR_P2");
            this.Property(t => t.DcrP3).HasColumnName("DCR_P3");
            this.Property(t => t.DcrP4).HasColumnName("DCR_P4");
            this.Property(t => t.DcrP5).HasColumnName("DCR_P5");
            this.Property(t => t.DcrP6).HasColumnName("DCR_P6");
            this.Property(t => t.Acao).HasColumnName("DCR_ACAO");
            this.Property(t => t.Detalhe).HasColumnName("DCR_DETTAREFA");

            // Relationships
            this.HasOptional(t => t.FMEA)
                .WithMany(t => t.ItensFMEA)
                .HasForeignKey(d => d.FMEAID);
            this.HasOptional(t => t.Tarefa)
                .WithMany(t => t.ItensFMEA)
                .HasForeignKey(d => d.TarefaID);

        }
    }
}
