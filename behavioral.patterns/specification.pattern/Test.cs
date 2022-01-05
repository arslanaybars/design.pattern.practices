using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace specification.pattern
{
    public class Test
    {
        public static List<Team> Teams => new List<Team>
        {
            new Team(1,"Besiktas","Istanbul", League.TurkishSuperLeague,17, new DateTime(1903,1,1) ),
            new Team(2,"Galatasaray","Istanbul", League.TurkishSuperLeague,22, new DateTime(1905,1,1) ),
            new Team(3,"Fenerbahce","Istanbul", League.TurkishSuperLeague,10, new DateTime(1907,1,1) ),
            new Team(4,"Real Madrid","Madrid", League.LaLiga,30, new DateTime(1902,1,1) ),
            new Team(5,"Barcelona","Barcelona", League.LaLiga,35, new DateTime(1899,1,1) )
        };

        [Fact]
        public void when_specify_by_league_and_city_returns_turkish_clubs_from_istanbul()
        {
            var filteredTeams = Teams.Filter(new TeamFilter
            {
                City = "Istanbul",
                League = League.TurkishSuperLeague,
            });

            Assert.Equal(3, filteredTeams.Count());
        }

        [Fact]
        public void when_specify_by_league_returns_turkish_clubs()
        {
            var filteredTeams = Teams.Filter(new TeamFilter
            {
                League = League.TurkishSuperLeague
            });

            Assert.Equal(3, filteredTeams.Count());
        }

        [Fact]
        public void when_no_filter_not_return_original_list()
        {
            var filteredTeams = Teams.Filter(null);

            Assert.Equal(5, filteredTeams.Count());
        }
    }
}
