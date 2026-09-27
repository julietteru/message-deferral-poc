namespace MessageDeferral.Services.Test.Competition;

public class CompetitionValidatorTests
{
    [Test]
    public async Task NameIsNotEmpty_Invalid(){}
    
    [Test]
    public async Task NameIsNotUnique_Invalid(){}
    
    [Test]
    public async Task NameProvidedAndUnique_Valid(){}
}