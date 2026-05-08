using VillageSimulator.Enums;
namespace VillageSimulator.Models;

public class Resource
{
    public ResourceType Type { get; private set; }
    public int CurrentQuantity { get; private set; }
    public int MaxCapacity { get; private set; }
    public int ProductionRate { get; private set; }
    public int ConsumptionRate { get; private set; }

    public Resource(ResourceType type, int currentQuantity, int maxCapacity, int productionRate, int consumptionRate)
    {
        Type = type;
        CurrentQuantity = currentQuantity;
        MaxCapacity = maxCapacity;
        ProductionRate = productionRate;
        ConsumptionRate = consumptionRate;
    }

    public void Add(int amount)
    {
        CurrentQuantity = Math.Min(CurrentQuantity + amount, MaxCapacity);
    }

    public bool Remove(int amount)
    {
        if (CurrentQuantity >= amount)
        {
            CurrentQuantity -= amount;
            return true;
        }
        return false;
    }

    public void UpdateDaily()
    {
        Add(ProductionRate);
        Remove(ConsumptionRate);
    }

    public bool IsLowStock(int threshold)
    {
        return CurrentQuantity < threshold;
    }
}