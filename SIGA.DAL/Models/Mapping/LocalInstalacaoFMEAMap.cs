using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class LocalInstalacaoFMEAMap : EntityTypeConfiguration<LocalInstalacaoFMEA>
    {
        public LocalInstalacaoFMEAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.FMEAID)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("LIFMEA");
            this.Property(t => t.ID).HasColumnName("COD_LIFMEA");
            this.Property(t => t.Tag).HasColumnName("COD_TAG");
            this.Property(t => t.FMEAID).HasColumnName("COD_FMEA");

            // Relationships
            this.HasRequired(t => t.FMEA)
                .WithMany(t => t.Locais)
                .HasForeignKey(d => d.FMEAID);
            this.HasRequired(t => t.LocalInstalacao)
                .WithMany(t => t.LocaisFMEA)
                .HasForeignKey(d => d.Tag);

        }
    }
}
