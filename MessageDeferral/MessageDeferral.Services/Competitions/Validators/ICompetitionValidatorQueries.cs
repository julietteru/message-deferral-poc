namespace MessageDeferral.Services.Competitions.Validators;

public interface ICompetitionValidatorQueries
{
    Task<bool> IsNameUnique(string name, int? currentId = null, CancellationToken cancellationToken = default);
}