using HistoricalBook.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HistoricalBook.DataAccess;

public class HistoricalBookDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CorrectionEntity> Corrections { get; set; }
    public DbSet<CultureEntity> Cultures { get; set; }
    public DbSet<EventEntity> Events { get; set; }
    public DbSet<NoteEntity> Notes { get; set; }
    public DbSet<PersonEntity> Persons { get; set; }
    
    public HistoricalBookDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
        
        modelBuilder.Entity<UserEntity>().HasMany(u => u.Permission)
            .WithMany(p => p.Users)
            .HasForeignKey(u => u.PermissionId);
       
    }
}