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
        Console.Write($"--- Village Simulator ----- {day} ---- {time} ---");
        RenderCurrentView();
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
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This is the overview view...");
    }
    private void RenderDetailView()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This is the detail view...");
    }


    // Subrendering methods:
    /*
    RenderVillageOverview() - Show resources, villager count, current day/time
    RenderVillagerDetails() - Show individual villager stats
    RenderResourceStatus() - Detailed resource breakdown
    RenderEventLog() - Show what happened today
    RenderCommands() - Display available commands
    */
}