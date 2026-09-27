using MessageDeferral.Entities.Competition;
using MessageDeferral.Entities.Matches;
using MessageDeferral.Entities.Teams;
using Microsoft.EntityFrameworkCore;
using Group = MessageDeferral.Entities.Competition.Group;

namespace MessageDeferral.Persistence;

public class DomainDbContext : DbContext
{
    public virtual DbSet<Competition> Competitions { get; set; }
    public virtual DbSet<Stage> Stages { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
    
    public virtual DbSet<Match> Matches { get; set; }
    public virtual DbSet<MatchEvent> MatchEvents { get; set; }
    public virtual DbSet<GoalEvent> GoalEvents { get; set; }
    public virtual DbSet<CardEvent> CardEvents { get; set; }
    public virtual DbSet<SubstitutionEvent> SubstitutionEvents { get; set; }
    public virtual DbSet<MatchResult> MatchResults { get; set; }
    
    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<Person> People { get; set; }
    public virtual DbSet<Player> Players { get; set; }
    public virtual DbSet<Official> Officials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().UseTphMappingStrategy();
        modelBuilder.Entity<MatchEvent>().UseTptMappingStrategy();
        
        base.OnModelCreating(modelBuilder);
    }
}