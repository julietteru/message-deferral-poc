using MessageDeferral.Entities.Competitions;
using MessageDeferral.Entities.Matches;
using MessageDeferral.Entities.Teams;
using MessageDeferral.Persistence.Repositories;
using Group = MessageDeferral.Entities.Competitions.Group;
using Match = System.Text.RegularExpressions.Match;

namespace MessageDeferral.Persistence;

public class UnitOfWork(
    IRepository<Competition> competitions,
    IRepository<Stage> stages,
    IRepository<Group> groups,
    IRepository<Match> matches,
    IRepository<MatchEvent> matchEvents,
    IRepository<GoalEvent> goalEvents,
    IRepository<CardEvent> cardEvents,
    IRepository<SubstitutionEvent> substitutionEvents,
    IRepository<MatchResult> matchResults,
    IRepository<Person> people,
    IRepository<Player> players,
    IRepository<Official> officials,
    IRepository<Team> teams,
    DomainDbContext dbContext)
    : IUnitOfWork
{
    public IRepository<Competition> Competitions { get; } = competitions;
    public IRepository<Stage> Stages { get; } = stages;
    public IRepository<Group> Groups { get; } = groups;
    public IRepository<Match> Matches { get; } = matches;
    public IRepository<MatchEvent> MatchEvents { get; } = matchEvents;
    public IRepository<GoalEvent> GoalEvents { get; } = goalEvents;
    public IRepository<CardEvent> CardEvents { get; } = cardEvents;
    public IRepository<SubstitutionEvent> SubstitutionEvents { get; } = substitutionEvents;
    public IRepository<MatchResult> MatchResults { get; } = matchResults;
    public IRepository<Person> People { get; } = people;
    public IRepository<Player> Players { get; } = players;
    public IRepository<Official> Officials { get; } = officials;
    public IRepository<Team> Teams { get; } = teams;

    public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.SaveChangesAsync(cancellationToken);
    }
}