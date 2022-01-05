using System;
using System.Linq.Expressions;

internal class CitySpecification : Specification<Team>
{
    private readonly string _city;

    public CitySpecification(string city)
    {
        _city = city;
    }

    public override Expression<Func<Team, bool>> ToExpression() => team => team.City == _city;
}
