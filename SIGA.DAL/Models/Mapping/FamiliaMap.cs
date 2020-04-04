using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class FamiliaMap : EntityTypeConfiguration<Familia>
    {
        public FamiliaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("FAMILIA");
            this.Property(t => t.ID).HasColumnName("COD_FAMILIA");
            this.Property(t => t.Descricao).HasColumnName("DCR_FAMILIA");
        }
    }
}
