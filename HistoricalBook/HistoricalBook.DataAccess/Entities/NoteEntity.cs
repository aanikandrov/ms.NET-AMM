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
    
    public List<UserNoteEntity> UserNote { get; set; } = new List<UserNoteEntity>();
    public List<NoteEventEntity> NoteEvent { get; set; } = new List<NoteEventEntity>();
    public List<NotePersonEntity> NotePerson { get; set; } = new List<NotePersonEntity>();
}