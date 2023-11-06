using NavalWarfareLITE.Entities;

namespace NavalWarfareLITE.Interfaces;

public class IShip
{
   

    public static Ship CreateShip(int x, int y, int lenght, int height,Player player)
    {
        return new Ship( x, y, lenght, height,player);
    }
    
    public static Map SetShip(Map map,Ship ship)
    {
        for (int i = 0; i < ship.Lenght; i++)
        {
            for (int j = 0; j < ship.Height; j++)
            {
                map = IMap.SetAt(map, ship);
            }
        }
        return map;
    }
}