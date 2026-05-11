namespace VillageSimulator.Models;

class TimeKeeper
{
    public DateTime StartDateTime { get; private set; }
    public DateTime CurrentDateTime { get; private set; }
    private int lastCheckedDay;
    public TimeKeeper(DateTime startDateTime)
    {
        StartDateTime = startDateTime;
        CurrentDateTime = startDateTime;
    }

    public void AdvanceTime(int minutes = 10)
    {
        CurrentDateTime = CurrentDateTime.AddMinutes(minutes);

    }

    public bool IsNewDay()
    {
        if (CurrentDateTime.Day != lastCheckedDay)
        {
            lastCheckedDay = CurrentDateTime.Day;
            return true;
        }
        return false;
    }
    // Formated string methods
    public string GetTimeString()
    {
        var hour = CurrentDateTime.Hour < 10 ? $"0{CurrentDateTime.Hour}" : $"{CurrentDateTime.Hour}";
        var minute = CurrentDateTime.Minute < 10 ? $"0{CurrentDateTime.Minute}" : $"{CurrentDateTime.Minute}";
        return $"{hour}:{minute}";
    }

    public string GetDayString()
    {
        return $"{CurrentDateTime.DayOfWeek}";
    }

}
