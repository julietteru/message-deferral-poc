namespace MessageDeferral.Entities.Competition;

public class Stage
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int PreviousId { get; set; }
    public Stage? Previous { get; set; }
    
    public int NextId { get; set; }
    public Stage? Next { get; set; }
    
    public int MaxTeams { get; set; }
    
}