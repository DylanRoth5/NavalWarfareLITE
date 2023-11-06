using NavalWarfareLITE.Entities;
using static NavalWarfareLITE.HelperSeal.Tools;
using static NavalWarfareLITE.Interfaces.IMap;
using static NavalWarfareLITE.Interfaces.IShip;

namespace NavalWarfareLITE.Matches;

public class Solo
{
    public static void Game(Player Player)
    {
        Player Enemy = new Player("Enemy");
        Map pMap = new Map(Player);
        Map eMap = new Map(Enemy);
        Random r = new Random();
        Ship ship1 = CreateShip(r.Next(0,8), r.Next(0,10), 3, 1,Player);
        Ship ship2 = CreateShip(r.Next(0,10), r.Next(0,8), 1, 3,Player);
        Ship ship3 = CreateShip(r.Next(0,9), r.Next(0,10), 2, 1,Player);
        Ship ship4 = CreateShip(r.Next(0,10), r.Next(0,9), 1, 2,Player);
        Ship eship1 = CreateShip(r.Next(0,8), r.Next(0,10), 3, 1,Enemy);
        Ship eship2 = CreateShip(r.Next(0,10), r.Next(0,8), 1, 3,Enemy);
        Ship eship3 = CreateShip(r.Next(0,9), r.Next(0,10), 2, 1,Enemy);
        Ship eship4 = CreateShip(r.Next(0,10), r.Next(0,9), 1, 2,Enemy);
        pMap = SetAt(pMap,ship1);
        pMap = SetAt(pMap,ship2);
        pMap = SetAt(pMap,ship3);
        pMap = SetAt(pMap,ship4);
        eMap = SetAt(eMap,eship1);
        eMap = SetAt(eMap,eship2);
        eMap = SetAt(eMap,eship3);
        eMap = SetAt(eMap,eship4);
        bool gaming = true;
        int X = 0;
        int Y = 0;
        while (gaming)
        {
            WriteLine();
            eMap.ShowMap(true);
            WriteLine();
            pMap.ShowMap(true);
            WriteLine();
            WriteLine("What to do next?");
            ConsoleKeyInfo k = Catch();
            if (k.Key == ConsoleKey.Enter) gaming = false;
            if (k.Key == ConsoleKey.UpArrow) Y--;
            if (k.Key == ConsoleKey.DownArrow) Y++;
            if (k.Key == ConsoleKey.RightArrow) X++;
            if (k.Key == ConsoleKey.LeftArrow) X--;
            if (X<0) X = 0;
            if (Y<0) Y = 0;
            if (X>10) X = 10;
            if (Y>10) Y = 10;
        }
    }
}