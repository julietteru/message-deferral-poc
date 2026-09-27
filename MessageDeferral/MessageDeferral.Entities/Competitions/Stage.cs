namespace MessageDeferral.Entities.Competitions;

public class Stage
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public int CompetitionId { get; set; }
    public Competition Competition { get; set; }
    
    public int PreviousId { get; set; }
    public Stage? Previous { get; set; }
    
    public int MaxTeams { get; set; }
    public ICollection<Group> Groups { get; set; } = new List<Group>();
}