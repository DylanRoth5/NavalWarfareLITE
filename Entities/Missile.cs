namespace NavalWarfareLITE.Entities;

public class Missile
{
    public static int Id;
    public string Skin = "  \u2591";
    public static string Skin2 = "  \u2591";
    public int XPos;
    public int YPos;
    public Player Gamer;

    public Missile(int id, int x,int y,Player gamer)
    {
        Id = id;
        XPos = x;
        YPos = y;
        Gamer = gamer;
    }
    public Missile(int x,int y,Player gamer)
    {
        XPos = x;
        YPos = y;
        Gamer = gamer;
    }
}