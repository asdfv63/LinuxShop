using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class PermissionMap : EntityTypeConfiguration<Permission>
    {
        public PermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionID);

            // Properties
            this.Property(t => t.PermissionID)
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
            this.ToTable("Permission", "MobilePhoneShopping");
            this.Property(t => t.PermissionID).HasColumnName("PermissionID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
