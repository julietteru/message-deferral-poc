using MessageDeferral.Entities.Teams;
using MessageDeferral.Entities.Matches;

namespace MessageDeferral.Entities.Competition;

public class Group
{
    public int Id { get; set; }
    public int Order { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? LocalTeamName { get; set; }
    public string? AwayTeamName { get; set; }
    
    public int StageId { get; set; }
    public Stage Stage { get; set; }
    
    public int? LocalTeamId { get; set; }
    public Team? LocalTeam { get; set; }
    
    public int? AwayTeamId { get; set; }
    public Team? AwayTeam { get; set; }
    
    public ICollection<Match> Matches { get; set; } = new List<Match>();
}