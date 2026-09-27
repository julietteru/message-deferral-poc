using System.Linq.Expressions;
using FluentAssertions;
using MessageDeferral.Persistence;
using MessageDeferral.Entities.Competitions;
using MessageDeferral.Entities.Enums;
using MessageDeferral.Services.Competitions.Validators;
using MockQueryable;
using NSubstitute;

namespace MessageDeferral.Services.Test.Competitions;

public class CompetitionValidatorQueriesTests
{
    private readonly IUnitOfWork _uow = Substitute.For<IUnitOfWork>();

    [Test]
    public async Task IsNameUnique_ReturnsFalse()
    {
        var competitions = new List<Competition>()
        {
            new Competition{ Id = 1, Name = "Test", Category = Category.TopTier, Gender = Gender.Male}
        };
        
        var competitionsQueryableMock = competitions.BuildMock();
        
        _uow.Competitions.Query(Arg.Any<Expression<Func<Competition, bool>>>())
            .Returns(competitionsQueryableMock);

        var queriesService = new CompetitionValidatorQueries(_uow);
        var result = await queriesService.IsNameUnique("Test");
        
        result.Should().BeFalse();
    }

    [Test]
    public async Task IsNameUnique_ReturnsTrue()
    {
        var competitions = new List<Competition>(){};
        
        _uow.Competitions.Query(Arg.Any<Expression<Func<Competition, bool>>>())
            .Returns(competitions.BuildMock());

        var queriesService = new CompetitionValidatorQueries(_uow);
        var result = await queriesService.IsNameUnique("New Competition");
        
        result.Should().BeTrue();
    }
    
    [Test]
    public async Task IsNameUnique_WhenIdIsProvidedAndNameIsRepeated_ReturnsFalse()
    {
        var competitions = new List<Competition>()
        {
            new Competition{ Id = 3, Name = "Comp", Category = Category.TopTier, Gender = Gender.Male},
        };
        
        _uow.Competitions.Query(Arg.Any<Expression<Func<Competition, bool>>>())
            .Returns(competitions.BuildMock());

        var queriesService = new CompetitionValidatorQueries(_uow);
        var result = await queriesService.IsNameUnique("Comp", 1);
        
        result.Should().BeFalse();
    }
    
    [Test]
    public async Task IsNameUnique_WhenIdIsProvidedAndNameIsNOTRepeated_ReturnsTrue()
    {
        var competitions = new List<Competition>(){};
        
        _uow.Competitions.Query(Arg.Any<Expression<Func<Competition, bool>>>())
            .Returns(competitions.BuildMock());

        var queriesService = new CompetitionValidatorQueries(_uow);
        var result = await queriesService.IsNameUnique("New Competition", 1);
        
        result.Should().BeTrue();
    }
    
    [Test]
    public async Task IsNameUnique_WhenIdIsProvidedAndNameIsTheSame_ReturnsTrue()
    {
        var competitions = new List<Competition>()
        {
            new Competition{ Id = 1, Name = "Test", Category = Category.TopTier, Gender = Gender.Male}
        };
        
        _uow.Competitions.Query(Arg.Any<Expression<Func<Competition, bool>>>())
            .Returns(competitions.BuildMock());

        var queriesService = new CompetitionValidatorQueries(_uow);
        var result = await queriesService.IsNameUnique("Test", 1);
        
        result.Should().BeTrue();
    }
}