using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Persons")]
public class PersonEntity : BaseEntity
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime DeathDate { get; set; }
    
    public List<NoteEntity> Notes { get; set; } = new List<NoteEntity>();
    public List<EventEntity> Events { get; set; } = new List<EventEntity>();
}