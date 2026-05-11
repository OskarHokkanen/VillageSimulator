using VillageSimulator.Enums;
using VillageSimulator.Models;

namespace VillageSimulator.UI;

class ConsoleUI
{
    public ViewType CurrentView { get; set; }
    public TimeKeeper TK { get; private set; }
    public ResourceManager RM { get; private set; }

    public ConsoleUI(TimeKeeper timeKeeper, ResourceManager resourceManager)
    {
        TK = timeKeeper;
        RM = resourceManager;
        CurrentView = ViewType.Overview;
    }

    public void Render()
    {
        // Clear
        // Check active screen
        // Call render submethod
        // Render Persistent layer 
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        var day = "Monday";
        var time = "12.54";

        RenderHeader();
        RenderCurrentView();
        RenderFooter();
    }

    private void RenderHeader()
    {
        Console.WriteLine("┌──────────────── Village Simulator ────────────────┐");
        Console.WriteLine($"| {TK.GetDayString()} {TK.GetTimeString()}                                    |");
    }

    private void RenderFooter()
    {
        Console.WriteLine("├───────────────────────────────────────────────────┤\n|       Views: [O]verview | [D]etail | E[X]it       |\n└───────────────────────────────────────────────────┘");
    }

    private void RenderCurrentView()
    {
        switch (CurrentView)
        {
            case ViewType.Detail:
                RenderDetailView();
                break;
            default:
                RenderOverviewView();
                break;
        }
    }

    private void RenderOverviewView()
    {
        var gold = RM.GetResourceQuantityOfType(ResourceType.Gold);
        var wood = RM.GetResourceQuantityOfType(ResourceType.Wood);
        var food = RM.GetResourceQuantityOfType(ResourceType.Food);
        //|---------------------------------------------------|
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                      Overview                     |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine($"| Gold: {gold}, Wood: {wood}, Food: {food} |");
        Console.WriteLine("|                                                   |");
    }
    private void RenderDetailView()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                       Detail                      |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
    }


    // Helper method for formatting terminal output

    private void FormattedPrintToConsole(string stringToPrint)
    {
        string topLeftCorner;

        string topRightCorner = "┐";
        string bottomLeftCorner;
        string bottomRightCorner = "┘";
        string sideEdge = "|";
        int lengthOfOutput = 53;
        int lengthOfString = stringToPrint.Length;



    }

    // Subrendering methods:
    /*

┌──────────────── Village Simulator ────────────────┐
|
|
|---------------------------------------------------|
├───────────────────────────────────────────────────┤
|       Views: [O]verview | [D]etail | E[X]it       |
└───────────────────────────────────────────────────┘
    RenderVillageOverview() - Show resources, villager count, current day/time
    RenderVillagerDetails() - Show individual villager stats
    RenderResourceStatus() - Detailed resource breakdown
    RenderEventLog() - Show what happened today
    RenderCommands() - Display available commands
    */
}