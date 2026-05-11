using VillageSimulator.Models;
using VillageSimulator.Enums;

namespace VillageSimulator.Models;

class ResourceManager
{
    private Dictionary<ResourceType, Resource> Resources;

    public ResourceManager()
    {
        Resources = new Dictionary<ResourceType, Resource>();
        AddInitialResources();
    }

    private void AddInitialResources()
    {
        var gold = new Resource(ResourceType.Gold, 0, 9999, 10, 5);
        var wood = new Resource(ResourceType.Wood, 0, 9999, 10, 5);
        var food = new Resource(ResourceType.Food, 0, 9999, 10, 5); //  TODO Calculate ConsumptionRate and ProductionRate on amount of villages

        Resources.Add(ResourceType.Gold, gold);
        Resources.Add(ResourceType.Wood, wood);
        Resources.Add(ResourceType.Food, food);
    }

    public void UpdateAllDailyResources()
    {
        foreach (var item in Resources)
        {
            item.Value.UpdateDaily();
        }
    }

    public int GetResourceQuantityOfType(ResourceType resourceType)
    {
        if (!Resources.ContainsKey(resourceType))
        {
            throw new ArgumentException($"Resource type '{resourceType}' not found", nameof(resourceType));
        }

        return Resources[resourceType].CurrentQuantity;
    }

}