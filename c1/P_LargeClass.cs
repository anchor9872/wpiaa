namespace launcher.c1;

public class WarehouseManager
{
    private readonly OrderProcessor _orderProcessor = new();
    private readonly InventoryManager _inventoryManager = new();
    private readonly DeliveryCoordinator _deliveryCoordinator = new();
    private readonly ReturnHandler _returnHandler = new();

    public void RunWarehouseTasks()
    {
        _orderProcessor.ProcessOrders();
        _inventoryManager.ManageInventory();
        _deliveryCoordinator.CoordinateDeliveries();
        _returnHandler.HandleReturns();
    }
}

public class OrderProcessor
{
    public void ProcessOrders()
    {
        Console.WriteLine("Processing orders.");
    }
}

public class InventoryManager
{
    public void ManageInventory()
    {
        Console.WriteLine("Managing inventory.");
    }
}

public class DeliveryCoordinator
{
    public void CoordinateDeliveries()
    {
        Console.WriteLine("Coordinating deliveries.");
    }
}

public class ReturnHandler
{
    public void HandleReturns()
    {
        Console.WriteLine("Handling returns.");
    }
}

// Kroki do wykonania:
// Utwórz osobne klasy OrderProcessor, InventoryManager, DeliveryCoordinator, i ReturnHandler.
//     Przenieś odpowiednie metody do tych nowych klas.
//     Usuń zbędne metody z klasy WarehouseManager i zachowaj tylko te, które są faktycznie związane z zarządzaniem magazynem na wysokim poziomie.
