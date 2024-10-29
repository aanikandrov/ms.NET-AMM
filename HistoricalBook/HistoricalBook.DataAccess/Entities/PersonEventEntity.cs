using System.ComponentModel.DataAnnotations.Schema;
namespace HistoricalBook.DataAccess.Entities;


[Table("NoteEvent")]
public class PersonEventEntity
{
    public int EventID { get; set; }
    public EventEntity Event { get; set; }
    
    public int PersonID { get; set; }
    public PersonEntity Person { get; set; }
}