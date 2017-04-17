using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class ShoppingCartMap : EntityTypeConfiguration<ShoppingCart>
    {
        public ShoppingCartMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.GoodsId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ShoppingCart", "MobilePhoneShopping");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.GoodsCount).HasColumnName("GoodsCount");
            this.Property(t => t.GoodsTotalPrice).HasColumnName("GoodsTotalPrice");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.ShoppingCarts)
                .HasForeignKey(d => d.UserId);

        }
    }
}
