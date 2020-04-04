using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class FMEAMap : EntityTypeConfiguration<FMEA>
    {
        public FMEAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.SiteID)
                .HasMaxLength(12);

            this.Property(t => t.FamiliaID)
                .HasMaxLength(12);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("FMEA");
            this.Property(t => t.ID).HasColumnName("COD_FMEA");
            this.Property(t => t.SiteID).HasColumnName("COD_SITE");
            this.Property(t => t.FamiliaID).HasColumnName("COD_FAMILIA");
            this.Property(t => t.Descricao).HasColumnName("DCR_FMEA");

            // Relationships
            this.HasOptional(t => t.Familia)
                .WithMany(t => t.FMEAs)
                .HasForeignKey(d => d.FamiliaID);
            this.HasOptional(t => t.Site)
                .WithMany(t => t.FMEAs)
                .HasForeignKey(d => d.SiteID);

        }
    }
}
