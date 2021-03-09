namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class khachhangDbContext : DbContext
    {
        public khachhangDbContext()
            : base("name=khachhangDbContext")
        {
        }

        public virtual DbSet <QLKH> QLKHs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
