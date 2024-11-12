using HistoricalBook.DataAccess.Entities;

namespace HistoricalBook.BusinessLogic.Users.Entities;

public class UserModel
{
    public int Id { get; set; }
    public Guid ExternalId { get; set; }
    public string Login { get; set; }
    public string HashPassword { get; set; }
    public string FullName { get; set; } 
    public string Email { get; set; }
    public Role Role { get; set; }
}