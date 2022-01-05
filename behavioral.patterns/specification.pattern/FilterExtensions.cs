using System.Collections.Generic;
using System.Linq;

public static class FilterExtensions
{
    public static IEnumerable<Team> Filter(this IEnumerable<Team> teams, TeamFilter teamFilter)
    {
        if (teamFilter == null)
        {
            return teams;
        }

        return teams.Where(SpecificationBuilder.Build(teamFilter).IsSatisfiedBy);
    }
}

