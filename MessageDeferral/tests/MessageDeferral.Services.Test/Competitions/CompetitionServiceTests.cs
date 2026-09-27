namespace MessageDeferral.Services.Test.Competitions;

public class CompetitionServiceTests
{
    [Test]
    public async Task CreateCompetition_Invalid_Failure(){}
    
    [Test]
    public async Task CreateCompetition_Valid_Success(){}
    
    [Test]
    public async Task UpdateCompetition_Invalid_Failure(){}
    
    [Test]
    public async Task UpdateCompetition_Valid_Success(){}
    
    [Test]
    public async Task DeleteCompetition_Invalid_Failure(){}

    [Test]
    public async Task DeleteCompetition_Valid_Success(){}
    
    [Test]
    public async Task GetCompetition_NotFound_Returns_Null(){}
    
    [Test]
    public async Task GetCompetition_Found_Returns_Competition(){}
    
    [Test]
    public async Task GetAllCompetitions_NoCompetitions_Returns_Empty(){}
    
    [Test]
    public async Task GetAllCompetitions_Success_Returns_AllCompetitions(){}
}