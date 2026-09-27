using MessageDeferral.Entities.Enums;
using MessageDeferral.Entities.Taxonomy;
using MessageDeferral.Entities.Teams;

namespace MessageDeferral.Entities.Matches;

public class MatchEvent
{
    public int Id { get; set; }
    public MatchEventType EventType { get; set; }
    
    public int SpanId { get; set; }
    public MatchTimeSpan Span { get; set; }
    
    public int Minute { get; set; }
    public int? Second { get; set; }
    public int? At { get; set; }
    
    public int TeamId { get; set; }
    public Team Team { get; set; }
}

public class GoalEvent : MatchEvent
{
    public int GoalById { get; set; }
    public Player GoalBy { get; set; }
    
    public int? AssistById { get; set; }
    public Player? AssistBy { get; set; }
}

public class CardEvent : MatchEvent
{
    public int PlayerId { get; set; }
    public Player Player { get; set; }
}

public class SubstitutionEvent : MatchEvent
{
    public int PlayerId { get; set; }
    public Player PlayerIn { get; set; }
    
    public int PlayerOutId { get; set; }
    public Player? PlayerOut { get; set; }
}