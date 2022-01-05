using System;
using System.Linq.Expressions;

public class LeagueSpecification : Specification<Team>
{
    private readonly League _league;
    public LeagueSpecification(League league) => _league = league;

    public override Expression<Func<Team, bool>> ToExpression()
    {
        return team => team.League == _league;
    }
}