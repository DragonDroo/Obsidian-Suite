using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Section>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.Note);
                entity.Property(e => e.SectionChief);
                entity.Property(e => e.SectionAdmin);
                entity.Property(e => e.DisplayOrder);
            });
        }
        public virtual DbSet<CprPool> CprPool { get; set; }
         
    }
}