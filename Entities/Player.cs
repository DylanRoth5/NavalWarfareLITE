namespace NavalWarfareLITE.Entities;

public class Player
{
    public static int Id;
    public static string? Name;

    public Player(int id, string? name)
    {
        Id = id;
        Name = name;
    }
    public Player(string? name)
    {
        Name = name;
    }
}