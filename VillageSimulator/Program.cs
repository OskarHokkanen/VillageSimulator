using VillageSimulator.Enums;
using VillageSimulator.Models;
using VillageSimulator.UI;

Console.WriteLine("Hello, my name is world, what is your name?");


Villager oskar = new Villager("Oskar", 27, JobType.Farmer);

ConsoleUI consoleUI = new ConsoleUI();
bool isRunning = true;
while (isRunning)
{

    consoleUI.Render();

    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.O)
        {
            consoleUI.CurrentView = ViewType.Overview;
        }
        else if (keyInfo.Key == ConsoleKey.D)
        {
            consoleUI.CurrentView = ViewType.Detail;
        }
        else if (keyInfo.Key == ConsoleKey.X)
        {
            isRunning = false;
        }
    }
    Thread.Sleep(100);

}



/*

┌──────────────── Village Simulator ────────────────┐
|
|
|
├───────────────────────────────────────────────────┤
|       Views: [O]verview | [D]etail | E[X]it       |
└───────────────────────────────────────────────────┘


*/


