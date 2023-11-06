using NavalWarfareLITE.Entities;

namespace NavalWarfareLITE.Interfaces;

public class IPlayer
{
    
    public static List<Player> Players = new List<Player>();

    public static void CreatePlayer(string? name)
    {
        Players.Add(new Player(Players.Count+1,name));    
    }
}