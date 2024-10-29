using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Notes")]
public class NoteEntity : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public int Rating { get; set; }
    
    public List<UserEntity> Users { get; set; } = new List<UserEntity>();
    public List<EventEntity> Events { get; set; } = new List<EventEntity>();
    public List<PersonEntity> Persons { get; set; } = new List<PersonEntity>();
}