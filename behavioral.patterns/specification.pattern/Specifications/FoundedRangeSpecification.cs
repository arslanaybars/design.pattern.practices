using System;
using System.Linq.Expressions;

internal class FoundedRangeSpecification : Specification<Team>
{
    private readonly DateTime _min;
    private readonly DateTime _max;

    public FoundedRangeSpecification(DateTime min, DateTime max)
    {
        _min = min;
        _max = max;
    }

    public override Expression<Func<Team, bool>> ToExpression() => team => team.Founded > _min && team.Founded < _max;
}

