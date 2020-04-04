using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class TipoPeriodoMap : EntityTypeConfiguration<TipoPeriodo>
    {
        public TipoPeriodoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("TIPOPERIODO");
            this.Property(t => t.ID).HasColumnName("COD_TIPOPERIODO");
            this.Property(t => t.Descricao).HasColumnName("DCR_TIPOPERIODO");
        }
    }
}
