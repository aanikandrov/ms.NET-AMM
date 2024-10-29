using System.ComponentModel.DataAnnotations.Schema;
namespace HistoricalBook.DataAccess.Entities;


[Table("NotePerson")]
public class NotePersonEntity
{
    public int PersonID { get; set; }
    public PersonEntity Person { get; set; }
    
    public int NoteID { get; set; }
    public UserEntity Note { get; set; }
}