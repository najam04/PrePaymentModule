using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PrePaymentModule.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) // Pass the options to the base constructor
        {
        }

        public DbSet<Installment> pp_Installments { get; set; }
        public DbSet<Prepayment> pp_PrePayments { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Voucher> pp_Vouchers { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prepayment>()
            .HasKey(p => p.Id);
            modelBuilder.Entity<AspNetUser>()
   .HasNoKey();
            modelBuilder.Entity<History>().ToTable("History");
        }
        public void SaveInstallments(List<Installment> installments)
        {
            pp_Installments.AddRange(installments);
            SaveChanges();
        }
    }
}
