using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.OrderNumber });

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.OrderNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GoodsId)
                .HasMaxLength(128);

            this.Property(t => t.GoodsName)
                .HasMaxLength(100);

            this.Property(t => t.LogisticsNumber)
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("OrderDetail", "MobilePhoneShopping");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderNumber).HasColumnName("OrderNumber");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LogisticsPrice).HasColumnName("LogisticsPrice");
            this.Property(t => t.LogisticsNumber).HasColumnName("LogisticsNumber");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(d => d.OrderNumber);

        }
    }
}
