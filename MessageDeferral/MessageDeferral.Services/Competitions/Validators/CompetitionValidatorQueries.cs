using MessageDeferral.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MessageDeferral.Services.Competitions.Validators;

public class CompetitionValidatorQueries(IUnitOfWork uow) : ICompetitionValidatorQueries
{
    public async Task<bool> IsNameUnique(string name, int? currentId = null, CancellationToken cancellationToken = default)
    {
        var query = uow.Competitions.Query(x => x.Name.Equals(name));
        if(currentId != null)
            query = query.Where(x => x.Id != currentId.Value);

        var isNameInDb = await query.AnyAsync(cancellationToken);
        return !isNameInDb;
    }
}