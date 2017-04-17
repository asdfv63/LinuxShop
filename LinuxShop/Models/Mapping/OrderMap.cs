using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderNumber);

            // Properties
            this.Property(t => t.OrderNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Order", "MobilePhoneShopping");
            this.Property(t => t.OrderNumber).HasColumnName("OrderNumber");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.GoodsCount).HasColumnName("GoodsCount");
            this.Property(t => t.GoodsTotalPrice).HasColumnName("GoodsTotalPrice");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.UserId);

        }
    }
}
