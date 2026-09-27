using MessageDeferral.Entities.Taxonomy;
using MessageDeferral.Entities.Teams;

namespace MessageDeferral.Entities.Matches;

public class MatchResult
{
    public int Id { get; set; }
    
    public int MatchId { get; set; }
    public Match Match { get; set; }
    
    public int TeamId { get; set; }
    public Team Team { get; set; }
    
    public int SpanId { get; set; }
    public MatchTimeSpan Span { get; set; }
    
    public int Goals { get; set; }
    public int Penalties { get; set; }
}