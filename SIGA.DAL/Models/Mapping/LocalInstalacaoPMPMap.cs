using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class LocalInstalacaoPMPMap : EntityTypeConfiguration<LocalInstalacaoPMP>
    {
        public LocalInstalacaoPMPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.PMPID)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("LIPMP");
            this.Property(t => t.ID).HasColumnName("COD_LIPMP");
            this.Property(t => t.Tag).HasColumnName("COD_TAG");
            this.Property(t => t.PMPID).HasColumnName("COD_PMP");

            // Relationships
            this.HasRequired(t => t.LocalInstalacao)
                .WithMany(t => t.LocaisPMP)
                .HasForeignKey(d => d.Tag);
            this.HasRequired(t => t.PMP)
                .WithMany(t => t.LocaisPMP)
                .HasForeignKey(d => d.PMPID);

        }
    }
}
