using System.ComponentModel.DataAnnotations.Schema;

namespace HistoricalBook.DataAccess.Entities;

[Table("Users")]
public class UserEntity : BaseEntity
{
    public string Login { get; set; }
    public string HashPassword { get; set; }
    public string Email { get; set; }
    public int Role { get; set; }
    
    public List<UserNoteEntity> UserNote { get; set; } //= new List<UserNoteEntity>();
}