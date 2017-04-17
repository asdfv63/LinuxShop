using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class RolePermissionMap : EntityTypeConfiguration<RolePermission>
    {
        public RolePermissionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoleID, t.PermissionID });

            // Properties
            this.Property(t => t.RoleID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PermissionID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("RolePermissions", "MobilePhoneShopping");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.PermissionID).HasColumnName("PermissionID");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Permission)
                .WithMany(t => t.RolePermissions)
                .HasForeignKey(d => d.PermissionID);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.RolePermissions)
                .HasForeignKey(d => d.RoleID);

        }
    }
}
