using VillageSimulator.Enums;

namespace VillageSimulator.Models;


public class Villager
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Hunger { get; private set; }
    public int Energy { get; private set; }
    private JobType Job;


    public Villager(string name, int age, JobType job)
    {
        Name = name;
        Age = age;
        Hunger = 100;
        Energy = 100;
        Job = job;
    }

    public int Eat()
    {
        var rand = new Random();
        var foodValue = rand.Next(40, 60);

        Hunger += foodValue;
        return Hunger;
    }

    public int Sleep()
    {
        var rand = new Random();
        var sleepValue = rand.Next(80, 101);

        Energy = sleepValue;
        return Energy;
    }

}