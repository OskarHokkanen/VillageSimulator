namespace VillageSimulator.Models;

class TimeKeeper
{
    public DateTime StartDateTime { get; private set; }
    public DateTime CurrentDateTime { get; private set; }
    public TimeKeeper(DateTime startDateTime)
    {
        StartDateTime = startDateTime;
        CurrentDateTime = startDateTime;
    }

    public void AdvanceTime(int minutes = 10)
    {
        CurrentDateTime = CurrentDateTime.AddMinutes(minutes);

    }

    public string GetTimeString()
    {
        return $"{CurrentDateTime.Hour}:{CurrentDateTime.Minute}";
    }

    public string GetDayString()
    {
        return $"{CurrentDateTime.DayOfWeek}";
    }

}
