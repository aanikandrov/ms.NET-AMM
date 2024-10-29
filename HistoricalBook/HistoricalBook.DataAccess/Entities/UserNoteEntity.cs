
using System.ComponentModel.DataAnnotations.Schema;
namespace HistoricalBook.DataAccess.Entities;


[Table("UserNote")]
public class UserNoteEntity 
{
    public int UserID { get; set; }
    public UserEntity User { get; set; }
    
    public int NoteID { get; set; }
    public UserEntity Note { get; set; }
}