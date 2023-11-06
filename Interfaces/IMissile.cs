using NavalWarfareLITE.Entities;

namespace NavalWarfareLITE.Interfaces;

public class IMissile
{
    public static List<Missile> Missiles = new ();

    public static void CreateMissile(int x, int y,Player player)
    {
        Missiles.Add(new Missile(Missiles.Count+1, x, y,player));    
    }
    
    public static void Launch(Map map,Missile misile)
    {
        IMap.LaunchAt(map, misile.XPos, misile.YPos, misile);
    }
}