using static System.ConsoleColor;
using static NavalWarfareLITE.HelperSeal.Tools;

namespace NavalWarfareLITE.Entities;

public class Map
{
    public int Id;
    public static string Spot = "  \u25a0";
    public string[,] Matrix = new string[10,10];
    public Player Gamer;

    public Map(int id,Player gamer)
    {
        Id = id;
        Gamer = gamer;
        CleanMap();
    }
    public Map(Player gamer)
    {
        Gamer = gamer;
        CleanMap();
    }

    public void CleanMap()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Matrix[i, j] = Spot;
            }
        }
    }

    public void ShowMap(bool ItsMe)
    {
        for (var i = 0; i < 10; i++)
        {
            for (var j = 0; j < 10; j++)
            {
                if (Matrix[i,j]==Missile.Skin2)
                {
                    Write(Matrix[i,j],Red);
                }else if (Matrix[i,j]==Ship.Skin2 && ItsMe)
                {
                    Write(Matrix[i,j],DarkMagenta);
                }else Write(Spot,Blue);
            }
            WriteLine();
        }
    }
    public void SelectInMap(bool ItsMe,int x,int y)
    {
        for (var i = 0; i < 10; i++)
        {
            for (var j = 0; j < 10; j++)
            {
                if (x==i && y==j) Flip();
                if (Matrix[i, j] == Missile.Skin2)
                    Write(Matrix[i, j], Red);
                else if (Matrix[i, j] == Ship.Skin2 && ItsMe)
                    Write(Matrix[i, j], DarkMagenta);
                else Write(Spot,Blue);
                if (x==i && y==j) Flip();
            }
            WriteLine();
        }
    }

    public bool HasShips()
    {
        for (var i = 0; i < 10; i++)
        for (var j = 0; j < 10; j++)
            if (Matrix[i, j] == Ship.Skin2)
                return true;
        return false;
    }
}