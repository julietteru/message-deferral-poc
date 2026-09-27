using MessageDeferral.Entities.Teams;
using MessageDeferral.Entities.Competitions;

namespace MessageDeferral.Entities.Matches;

public class Match
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeOnly KickOff { get; set; }
    
    public int GroupId { get; set; }
    public Group Group { get; set; }
    
    public int LocalTeamId { get; set; }
    public Team LocalTeam { get; set; }
    
    public int AwayTeamId { get; set; }
    public Team AwayTeam { get; set; }
    
    public ICollection<MatchEvent> Events { get; set; } =  new List<MatchEvent>();
    public ICollection<MatchResult> Results { get; set; } =  new List<MatchResult>();
}