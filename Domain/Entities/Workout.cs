namespace Domain.Entities;

public class Workout
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }  // Foreign key reference

    public string Name { get; set; } = null!;

    public string? Description { get; set; }  // Nullable

    public DateTime CreatedAt { get; set; }
}