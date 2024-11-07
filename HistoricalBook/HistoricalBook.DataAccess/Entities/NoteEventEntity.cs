using System.ComponentModel.DataAnnotations.Schema;
namespace HistoricalBook.DataAccess.Entities;


[Table("NoteEvent")]
public class NoteEventEntity
{
    public int EventID { get; set; }
    public EventEntity Event { get; set; }
    
    public int NoteID { get; set; }
    public NoteEntity Note { get; set; }
}