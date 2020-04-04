using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class LocalInstalacaoMap : EntityTypeConfiguration<LocalInstalacao>
    {
        public LocalInstalacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Tag);

            // Properties
            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FamiliaID)
                .HasMaxLength(12);

            this.Property(t => t.ProcessoID)
                .HasMaxLength(12);

            this.Property(t => t.UsinaID)
                .HasMaxLength(12);

            this.Property(t => t.DisciplinaID)
                .HasMaxLength(12);

            this.Property(t => t.SiteID)
                .HasMaxLength(12);

            this.Property(t => t.SubSistema)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.TagPai)
                .HasMaxLength(32);

            this.Property(t => t.Critico)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("LI");
            this.Property(t => t.Tag).HasColumnName("COD_TAG");
            this.Property(t => t.FamiliaID).HasColumnName("COD_FAMILIA");
            this.Property(t => t.ProcessoID).HasColumnName("COD_PROCESSO");
            this.Property(t => t.UsinaID).HasColumnName("COD_USINA");
            this.Property(t => t.DisciplinaID).HasColumnName("COD_DISCIPLINA");
            this.Property(t => t.SiteID).HasColumnName("SIT_COD_SITE");
            this.Property(t => t.SubSistema).HasColumnName("DCR_SUBSISTEMA");
            this.Property(t => t.TagPai).HasColumnName("COD_TAGPAI");
            this.Property(t => t.Critico).HasColumnName("DCR_CRITICO");

            // Relationships
            this.HasOptional(t => t.Disciplina)
                .WithMany(t => t.Locais)
                .HasForeignKey(d => d.DisciplinaID);
            this.HasOptional(t => t.Familia)
                .WithMany(t => t.Locais)
                .HasForeignKey(d => d.FamiliaID);
            this.HasOptional(t => t.Site)
                .WithMany(t => t.Locais)
                .HasForeignKey(d => d.SiteID);
            this.HasOptional(t => t.Processo)
                .WithMany(t => t.Locais)
                .HasForeignKey(d => d.ProcessoID);
            this.HasOptional(t => t.Usina)
                .WithMany(t => t.Locais)
                .HasForeignKey(d => d.UsinaID);

        }
    }
}
