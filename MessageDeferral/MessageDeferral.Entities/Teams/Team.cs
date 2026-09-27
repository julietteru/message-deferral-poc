using MessageDeferral.Entities.Enums;
namespace MessageDeferral.Entities.Teams;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Category Category { get; set; }
    public Gender Gender { get; set; }
    public ICollection<Player> Players { get; set; } = new List<Player>();
    public ICollection<Official> Officials { get; set; } = new List<Official>();
}