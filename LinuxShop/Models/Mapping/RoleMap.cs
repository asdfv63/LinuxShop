using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleID);

            // Properties
            this.Property(t => t.RoleID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Roles", "MobilePhoneShopping");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
