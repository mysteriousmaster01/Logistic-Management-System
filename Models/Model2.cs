using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Logister.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<export> exports { get; set; }
        public virtual DbSet<import> imports { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<export>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<export>()
                .Property(e => e.Transport_Via)
                .IsUnicode(false);

            modelBuilder.Entity<export>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<export>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<export>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.Sender)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.Transport_Via)
                .IsUnicode(false);

            modelBuilder.Entity<import>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
