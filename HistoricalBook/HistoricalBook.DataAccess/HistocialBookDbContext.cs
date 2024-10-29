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
    
    public DbSet<UserNoteEntity> UserNotes { get; set; }
    public DbSet<NoteEventEntity> NoteEvents { get; set; }
    public DbSet<NotePersonEntity> NotePersons { get; set; }
    public DbSet<PersonEventEntity> PersonEvents { get; set; }

    
    public HistoricalBookDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
        
        modelBuilder.Entity<NoteEntity>().HasKey(n => n.Id);
        
        modelBuilder.Entity<CultureEntity>().HasKey(cu => cu.Id);

        modelBuilder.Entity<CorrectionEntity>().HasKey(co => co.Id);

        modelBuilder.Entity<PersonEntity>().HasKey(p => p.Id);

        modelBuilder.Entity<EventEntity>().HasKey(e => e.Id);

        
        
        
        modelBuilder.Entity<UserNoteEntity>()
            .HasKey(un => new { un.UserID, un.NoteID });

        modelBuilder.Entity<UserNoteEntity>()
            .HasOne(un => un.User)
            .WithMany(u => u.UserNote)
            .HasForeignKey(un => un.UserID);

        modelBuilder.Entity<UserNoteEntity>()
            .HasOne(un => un.Note)
            .WithMany(n => n.UserNote)
            .HasForeignKey(un => un.NoteID);
        
        
        
        
        modelBuilder.Entity<NotePersonEntity>()
            .HasKey(pn => new { pn.PersonID, pn.NoteID });

        modelBuilder.Entity<NotePersonEntity>()
            .HasOne(pn => pn.Person)
            .WithMany(p => p.NotePerson)
            .HasForeignKey(pn => pn.PersonID);

        modelBuilder.Entity<NotePersonEntity>()
            .HasOne(pn => pn.Note)
            .WithMany(p => p.NotePerson)
            .HasForeignKey(pn => pn.NoteID);
       
        
        
        modelBuilder.Entity<NoteEventEntity>()
            .HasKey(ne => new { ne.NoteID, ne.EventID });

        modelBuilder.Entity<NoteEventEntity>()
            .HasOne(ne => ne.Event)
            .WithMany(e => e.NoteEvent)
            .HasForeignKey(pn => pn.EventID);

        modelBuilder.Entity<NoteEventEntity>()
            .HasOne(ne => ne.Event)
            .WithMany(n => n.NoteEvent)
            .HasForeignKey(pn => pn.NoteID);
        
        
        
        modelBuilder.Entity<PersonEventEntity>()
            .HasKey(pe => new { pe.PersonID, pe.EventID });

        modelBuilder.Entity<PersonEventEntity>()
            .HasOne(pe => pe.Event)
            .WithMany(e => e.PersonEvent)
            .HasForeignKey(pe => pe.EventID);

        modelBuilder.Entity<PersonEventEntity>()
            .HasOne(pe => pe.Event)
            .WithMany(n => n.PersonEvent)
            .HasForeignKey(pe => pe.PersonID);
    }
}