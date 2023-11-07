using NavalWarfareLITE.Entities;
using NavalWarfareLITE.Interfaces;
using static NavalWarfareLITE.HelperSeal.Tools;
using static NavalWarfareLITE.Interfaces.IMap;
using static NavalWarfareLITE.Interfaces.IShip;

namespace NavalWarfareLITE.Matches;

public class Coop
{
    public static void Game(Player Player1,Player Player2)
    {
        Map pMap = new Map(Player1);
        Map eMap = new Map(Player2);
        Random r = new Random();
        Ship ship1 = CreateShip(r.Next(0,8), r.Next(0,10), 3, 1,Player1);
        Ship ship2 = CreateShip(r.Next(0,10), r.Next(0,8), 1, 3,Player1);
        Ship ship3 = CreateShip(r.Next(0,9), r.Next(0,10), 2, 1,Player1);
        Ship ship4 = CreateShip(r.Next(0,10), r.Next(0,9), 1, 2,Player1);
        Ship eship1 = CreateShip(r.Next(0,8), r.Next(0,10), 3, 1,Player2);
        Ship eship2 = CreateShip(r.Next(0,10), r.Next(0,8), 1, 3,Player2);
        Ship eship3 = CreateShip(r.Next(0,9), r.Next(0,10), 2, 1,Player2);
        Ship eship4 = CreateShip(r.Next(0,10), r.Next(0,9), 1, 2,Player2);
        pMap = SetAt(pMap,ship1);
        pMap = SetAt(pMap,ship2);
        pMap = SetAt(pMap,ship3);
        pMap = SetAt(pMap,ship4);
        eMap = SetAt(eMap,eship1);
        eMap = SetAt(eMap,eship2);
        eMap = SetAt(eMap,eship3);
        eMap = SetAt(eMap,eship4);
        bool gaming = true;
        int Y = 0;
        int X = 0;
        int Y2 = 0;
        int X2 = 0;
        while (gaming)
        {
            WriteLine();
            eMap.SelectInMap(false,X,Y);
            WriteLine();
            pMap.ShowMap(true);
            WriteLine();
            ConsoleKeyInfo k = Catch();
            if (k.Key == ConsoleKey.Tab) gaming = false;
            if (k.Key == ConsoleKey.Enter)
            {
                eMap = LaunchAt(eMap,new Missile(X,Y,Player1));
                Clear();
                WriteLine();
                eMap.ShowMap(false);
                WriteLine();
                pMap.ShowMap(true);
                WriteLine();
                Catch();
                Clear();
                WriteLine("Player 2 Turn");
                Catch();
                Clear();
                bool NextTurn = true;
                while (NextTurn)
                {
                    WriteLine();
                    eMap.ShowMap(true);
                    WriteLine();
                    pMap.SelectInMap(false,X2,Y2);
                    WriteLine();
                    ConsoleKeyInfo j = Catch();
                    if (j.Key == ConsoleKey.Tab)
                    {
                        gaming = false;
                        break;
                    }
                    if (j.Key == ConsoleKey.Enter)
                    {
                        pMap = LaunchAt(pMap,new Missile(X2,Y2,Player2));
                        Clear();
                        WriteLine();
                        eMap.ShowMap(true);
                        WriteLine();
                        pMap.ShowMap(false);
                        WriteLine();
                        Catch();
                        Clear();
                        WriteLine("Player 1 Turn");
                        Catch();
                        Clear();
                        NextTurn = false;
                    }
                    if (j.Key == ConsoleKey.UpArrow) X2--;
                    if (j.Key == ConsoleKey.DownArrow) X2++;
                    if (j.Key == ConsoleKey.RightArrow) Y2++;
                    if (j.Key == ConsoleKey.LeftArrow) Y2--;
                    if (Y2<0) Y2 = 0;
                    if (X2<0) X2 = 0;
                    if (Y2>10) Y2 = 10;
                    if (X2>10) X2 = 10;
                    if (!eMap.HasShips())
                    {
                        Clear();
                        Write("You Win!!");
                        Catch();
                        gaming = false;
                        break;
                    }
                    if (!pMap.HasShips())
                    {
                        Clear();
                        Write("You Lose!!");
                        Catch();
                        gaming = false;
                        break;
                    }
                    Clear();
                }
            }
            if (k.Key == ConsoleKey.UpArrow) X--;
            if (k.Key == ConsoleKey.DownArrow) X++;
            if (k.Key == ConsoleKey.RightArrow) Y++;
            if (k.Key == ConsoleKey.LeftArrow) Y--;
            if (Y<0) Y = 0;
            if (X<0) X = 0;
            if (Y>10) Y = 10;
            if (X>10) X = 10;
            if (!eMap.HasShips())
            {
                Clear();
                Write("You Win!!");
                Catch();
                gaming = false;
            }
            if (!pMap.HasShips())
            {
                Clear();
                Write("You Lose!!");
                Catch();
                gaming = false;
            }
            Clear();
        }
    }
}