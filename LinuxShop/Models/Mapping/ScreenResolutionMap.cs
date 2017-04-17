using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class ScreenResolutionMap : EntityTypeConfiguration<ScreenResolution>
    {
        public ScreenResolutionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("ScreenResolution", "MobilePhoneShopping");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
