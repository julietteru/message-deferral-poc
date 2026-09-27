using MessageDeferral.Entities.Enums;
using MessageDeferral.Entities.Taxonomy;

namespace MessageDeferral.Entities.Teams;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public class Player : Person
{
    public Position Position { get; set; }
    public bool IsSubstitute { get; set; }
    public string ShirtName { get; set; } = string.Empty;
    public int ShirtNumber { get; set; }
}

public class Official : Person
{
    public OfficialRole Role { get; set; }
    public int RoleId { get; set; }
}