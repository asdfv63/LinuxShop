using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.RoleId });

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.RoleId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("UserRoles", "MobilePhoneShopping");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.CreateUsereId).HasColumnName("CreateUsereId");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.RoleId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.UserID);

        }
    }
}
