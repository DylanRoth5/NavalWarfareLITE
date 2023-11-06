namespace NavalWarfareLITE.Entities;

public class Ship
{
    public static int Id;
    public string Skin = "  █";
    public static string Skin2 = "  █";
    public int XPos;
    public int YPos;
    public int Lenght;
    public int Height;
    public Player Gamer;

    public Ship(int id, int x,int y, int lenght, int height,Player gamer)
    {
        Id = id;
        XPos = x;
        YPos = y;
        Lenght = lenght;
        Height = height;
        Gamer = gamer;
    }
    public Ship(int x,int y, int lenght, int height,Player gamer)
    {
        XPos = x;
        YPos = y;
        Lenght = lenght;
        Height = height;
        Gamer = gamer;
    }
}