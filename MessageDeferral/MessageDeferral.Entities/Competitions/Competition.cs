using MessageDeferral.Entities.Enums;

namespace MessageDeferral.Entities.Competitions;

public class Competition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Category Category { get; set; }
    public Gender Gender { get; set; }

    public ICollection<Stage> Stages { get; set; } = new List<Stage>();
}