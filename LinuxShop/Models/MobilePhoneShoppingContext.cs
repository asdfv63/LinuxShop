using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LinuxShop.Models.Mapping;

namespace LinuxShop.Models
{
    public partial class MobilePhoneShoppingContext : DbContext
    {
        static MobilePhoneShoppingContext()
        {
            Database.SetInitializer<MobilePhoneShoppingContext>(null);
        }

        public MobilePhoneShoppingContext()
            : base("Name=MobilePhoneShoppingContext")
        {
        }

        public DbSet<BrandType> BrandTypes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<MobilePhoneGood> MobilePhoneGoods { get; set; }
        public DbSet<OperatorSystem> OperatorSystems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PhoneModel> PhoneModels { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ScreenResolution> ScreenResolutions { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandTypeMap());
            modelBuilder.Configurations.Add(new ColorMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new MemoryMap());
            modelBuilder.Configurations.Add(new MobilePhoneGoodMap());
            modelBuilder.Configurations.Add(new OperatorSystemMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new PermissionMap());
            modelBuilder.Configurations.Add(new PhoneModelMap());
            modelBuilder.Configurations.Add(new RolePermissionMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new ScreenResolutionMap());
            modelBuilder.Configurations.Add(new ShoppingCartMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
