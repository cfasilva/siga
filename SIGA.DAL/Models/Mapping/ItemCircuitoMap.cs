using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SIGA.DAL
{
    public class ItemCircuitoMap : EntityTypeConfiguration<ItemCircuito>
    {
        public ItemCircuitoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CircuitoID)
                .HasMaxLength(12);

            this.Property(t => t.Tag)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ITEMCIRCUITO");
            this.Property(t => t.ID).HasColumnName("COD_ITEMCIRCUITO");
            this.Property(t => t.CircuitoID).HasColumnName("COD_CIRCUITO");
            this.Property(t => t.Tag).HasColumnName("COD_TAG");

            // Relationships
            this.HasOptional(t => t.Circuito)
                .WithMany(t => t.Itens)
                .HasForeignKey(d => d.CircuitoID);
            this.HasOptional(t => t.Local)
                .WithMany(t => t.ItensCircuito)
                .HasForeignKey(d => d.Tag);

        }
    }
}
