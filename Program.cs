using System.Runtime.CompilerServices;
using NavalWarfareLITE.Entities;
using NavalWarfareLITE.HelperSeal;
using NavalWarfareLITE.Interfaces;
using NavalWarfareLITE.Matches;
using static NavalWarfareLITE.HelperSeal.Tools;

namespace NavalWarfareLITE;

internal static class Program
{
    public static Player MainPlayer;
    private static void Main()
    {
        // Conexion.OpenConnection();
        Menu();
        // Conexion.CloseConnection();
    }

    private static void Menu()
    {
        while (true)
        {
            string[] options = { "Solo", "Coop", "Options"};
            var result = Tools.Menu("Calendar", options);
            switch (result)
            {
                case 1:
                    Solo.Game(MainPlayer);
                    continue;
                case 2:
                    continue;
                case 3:
                    continue;
            }
            break;
        }
    }
}