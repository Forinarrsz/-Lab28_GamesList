using GamesApi.Models;
namespace GamesApi.Data;

public static class GamesStore
{
    private static int _nextId = 4;
    public static List<Game> Games { get; } = new()
    {
        new Game
        {
            Id = 1,
            Title = "Resident Evil",
            Genre = "Sirvival Horror",
            ReleaseYear = 1996,
        },
        new Game
        {
            Id = 2,
            Title = "Resident Evil 2 Remake",
            Genre = "Sirvival Horror",
            ReleaseYear = 2019,
        },
        new Game
        {
            Id = 1,
            Title = "Resident Evil requiem",
            Genre = "Sirvival Horror",
            ReleaseYear = 2025,
        },
    };
    public static int NextId() => _nextId++;
}