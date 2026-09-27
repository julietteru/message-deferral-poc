using MessageDeferral.Entities.Competitions;
using MessageDeferral.Entities.Matches;
using MessageDeferral.Entities.Teams;
using MessageDeferral.Persistence.Repositories;
using Group = MessageDeferral.Entities.Competitions.Group;
using Match = System.Text.RegularExpressions.Match;

namespace MessageDeferral.Persistence;

public interface IUnitOfWork
{
    Task<int> CommitAsync(CancellationToken cancellationToken = default);

    #region Repositories

    IRepository<Competition> Competitions { get; }
    IRepository<Stage>  Stages { get; }
    IRepository<Group>  Groups { get; }
    
    IRepository<Match>  Matches { get; }
    IRepository<MatchEvent>  MatchEvents { get; }
    IRepository<GoalEvent>  GoalEvents { get; }
    IRepository<CardEvent>  CardEvents { get; }
    IRepository<SubstitutionEvent>  SubstitutionEvents { get; }
    IRepository<MatchResult>  MatchResults { get; }
    
    IRepository<Person> People { get; }
    IRepository<Player> Players { get; }
    IRepository<Official> Officials { get; }
    IRepository<Team> Teams { get; }
    
    #endregion
}