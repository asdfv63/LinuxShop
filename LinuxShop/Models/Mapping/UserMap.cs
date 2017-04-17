using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApplication1.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.UserDspName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MobilePhone)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.EmployeeId)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Activity)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CardId)
                .HasMaxLength(20);

            this.Property(t => t.Style)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Users", "MobilePhoneShopping");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.UserDspName).HasColumnName("UserDspName");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.BirthDay).HasColumnName("BirthDay");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.Activity).HasColumnName("Activity");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.Style).HasColumnName("Style");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
        }
    }
}
