using NavalWarfareLITE.Entities;

namespace NavalWarfareLITE.Interfaces;

public class IMap
{
    public static List<Map> Maps = new List<Map>();

    public static void CreateMap(Player player)
    {
        Maps.Add(new Map(Maps.Count+1,player));    
    }

    public static Map SetAt(Map map, Ship ship)
    {
        for (int i = 0; i < ship.Lenght; i++)
        {
            for (int j = 0; j < ship.Height; j++)
            {
                map.Matrix[ship.XPos+i, ship.YPos+j] = ship.Skin;
            }
        }
        return map;
    }
    public static Map LaunchAt(Map map, int posX, int posY, Missile missile)
    {
        map.Matrix[posX, posY] = missile.Skin;
        return map;
    }
}