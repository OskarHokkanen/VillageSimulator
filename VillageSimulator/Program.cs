using VillageSimulator.Enums;
using VillageSimulator.Models;
using VillageSimulator.UI;

Console.WriteLine("Hello, my name is world, what is your name?");


Villager oskar = new Villager("Oskar", 27, JobType.Farmer);

TimeKeeper timeKeeper = new TimeKeeper(new DateTime(1999, 03, 20, 0, 0, 0));
ResourceManager resourceManager = new ResourceManager();
ConsoleUI consoleUI = new ConsoleUI(timeKeeper, resourceManager);
bool isRunning = true;
while (isRunning)
{

    consoleUI.Render();
    timeKeeper.AdvanceTime(10);
    if (timeKeeper.IsNewDay())
    {
        resourceManager.UpdateAllDailyResources();
    }

    // User Inputs
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


