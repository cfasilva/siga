using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class ItemLocalPMPMap : EntityTypeConfiguration<ItemLocalPMP>
    {
        public ItemLocalPMPMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Tag)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ITEMLIPMP");
            this.Property(t => t.ID).HasColumnName("COD_ITEMLIPMP");
            this.Property(t => t.Tag).HasColumnName("COD_TAG");
            this.Property(t => t.ItemID).HasColumnName("COD_ITEMPMP");
            this.Property(t => t.SemanaInicio).HasColumnName("INT_SEMANAINICIO");
            this.Property(t => t.Periodo).HasColumnName("INT_PERIODO");
            this.Property(t => t.PeriodoEquipa).HasColumnName("INT_PERIODOEQUIPA");
            this.Property(t => t.PeriodoCircuito).HasColumnName("INT_PERIODOCIRCUITO");

            // Relationships
            this.HasOptional(t => t.Local)
                .WithMany(t => t.ItensLocalPMP)
                .HasForeignKey(d => d.Tag);
            this.HasOptional(t => t.Item)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.ItemID);

        }
    }
}
