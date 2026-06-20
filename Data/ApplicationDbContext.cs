    using Microsoft.EntityFrameworkCore;
    namespace _2526_2221050242_BaiThi.Models;

    namespace _2526_2221050242_BaiThi.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
            
            public DbSet <PhongBan> PhongBans  { get; set; }
            public DbSet <NhanVien> NhanViens { get; set; }
        }
    }
