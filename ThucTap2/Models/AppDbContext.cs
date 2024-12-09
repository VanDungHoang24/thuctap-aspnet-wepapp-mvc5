using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThucTap2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string connectionString) : base(connectionString)
        {
        }

        // Thêm các DbSet đại diện cho bảng trong cơ sở dữ liệu
        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}