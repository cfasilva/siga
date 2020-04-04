using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class UsinaMap : EntityTypeConfiguration<Usina>
    {
        public UsinaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.SiteID)
                .HasMaxLength(12);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("USINA");
            this.Property(t => t.ID).HasColumnName("COD_USINA");
            this.Property(t => t.EmpresaID).HasColumnName("COD_EMPRESA");
            this.Property(t => t.SiteID).HasColumnName("COD_SITE");
            this.Property(t => t.Descricao).HasColumnName("DCR_USINA");

            // Relationships
            this.HasOptional(t => t.Empresa)
                .WithMany(t => t.Usinas)
                .HasForeignKey(d => d.EmpresaID);
            this.HasOptional(t => t.Site)
                .WithMany(t => t.Usinas)
                .HasForeignKey(d => d.SiteID);

        }
    }
}
