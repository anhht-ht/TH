using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TH.Models
{
    public partial class THDbContext : DbContext
    {
        public THDbContext()
            : base("name=THDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
