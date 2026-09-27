using MessageDeferral.Entities.Enums;

namespace MessageDeferral.Entities.Taxonomy;

public class MatchTimeSpan
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int MinMinutes { get; set; }
    public int MaxMinutes { get; set; }
    public int MinSeconds { get; set; }
    public int MaxSeconds { get; set; }
    public bool AllowsAt { get; set; }
}