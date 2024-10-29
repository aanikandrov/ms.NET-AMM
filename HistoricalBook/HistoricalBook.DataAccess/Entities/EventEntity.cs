using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Events")]
public class EventEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public List<NoteEntity> Notes { get; set; } = new List<NoteEntity>();
    public List<PersonEntity> Events { get; set; } = new List<PersonEntity>();
}