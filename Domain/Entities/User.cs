namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }  // Unique identifier

    public string Username { get; set; } = null!; 
    // null! tells compiler we will assign it later (avoids warnings)

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}