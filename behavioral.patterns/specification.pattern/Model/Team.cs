using System;

public class Team
{
    public Team(int id, string name, string city, League league, ushort titles, DateTime founded)
    {
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        City = city ?? throw new ArgumentNullException(nameof(city));
        League = league;
        Titles = titles;
        Founded = founded;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public League League { get; set; }
    public ushort Titles { get; set; }
    public DateTime Founded { get; set; }
}
