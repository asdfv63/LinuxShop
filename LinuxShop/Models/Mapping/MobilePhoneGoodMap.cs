using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class MobilePhoneGoodMap : EntityTypeConfiguration<MobilePhoneGood>
    {
        public MobilePhoneGoodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserId)
                .HasMaxLength(128);

            this.Property(t => t.Status)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("MobilePhoneGoods", "MobilePhoneShopping");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.BrandType).HasColumnName("BrandType");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.System).HasColumnName("System");
            this.Property(t => t.ScreenResolution).HasColumnName("ScreenResolution");
            this.Property(t => t.Memory).HasColumnName("Memory");
            this.Property(t => t.PhoneModel).HasColumnName("PhoneModel");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.BrandType1)
                .WithMany(t => t.MobilePhoneGoods)
                .HasForeignKey(d => d.BrandType);
            this.HasOptional(t => t.Color1)
                .WithMany(t => t.MobilePhoneGoods)
                .HasForeignKey(d => d.Color);
            this.HasOptional(t => t.Memory1)
                .WithMany(t => t.MobilePhoneGoods)
                .HasForeignKey(d => d.Memory);
            this.HasOptional(t => t.PhoneModel1)
                .WithMany(t => t.MobilePhoneGoods)
                .HasForeignKey(d => d.PhoneModel);
            this.HasOptional(t => t.ScreenResolution1)
                .WithMany(t => t.MobilePhoneGoods)
                .HasForeignKey(d => d.ScreenResolution);
            this.HasOptional(t => t.OperatorSystem)
                .WithMany(t => t.MobilePhoneGoods)
                .HasForeignKey(d => d.System);

        }
    }
}
