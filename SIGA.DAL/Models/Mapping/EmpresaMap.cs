using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("EMPRESA");
            this.Property(t => t.ID).HasColumnName("COD_EMPRESA");
            this.Property(t => t.Descricao).HasColumnName("DCR_EMPRESA");
        }
    }
}
