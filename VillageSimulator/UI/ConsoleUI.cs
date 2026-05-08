using VillageSimulator.Enums;

namespace VillageSimulator.UI;

class ConsoleUI
{
    public ViewType CurrentView { get; set; }

    public ConsoleUI()
    {
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
        //|---------------------------------------------------|
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                      Overview                     |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
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