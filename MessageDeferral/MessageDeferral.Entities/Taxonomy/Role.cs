namespace MessageDeferral.Entities.Taxonomy;

public class OfficialRole
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTimeOffset ActiveFrom { get; set; }
    public DateTimeOffset ActiveTo { get; set; }
}