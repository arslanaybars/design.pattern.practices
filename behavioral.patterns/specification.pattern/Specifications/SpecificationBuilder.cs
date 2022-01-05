using System.Collections.Generic;
using System.Linq;

public static class SpecificationBuilder
{
    public static Specification<Team> Build(TeamFilter filter)
    {
        var funcList = new List<Specification<Team>>();

        if (!string.IsNullOrEmpty(filter.City))
        {
            funcList.Add(new CitySpecification(filter.City));
        }

        if (filter.League != League.None)
        {
            funcList.Add(new LeagueSpecification(filter.League));
        }

        if (filter.FoundedMin.HasValue || filter.FoundedMax.HasValue)
        {
            funcList.Add(new FoundedRangeSpecification(filter.FoundedMin.Value, filter.FoundedMax.Value));
        }

        if (funcList.Count == 1)
        {
            return funcList[0];
        }

        return funcList.Aggregate((left, right) => left.And(right));
    }
}

