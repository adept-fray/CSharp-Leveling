namespace VehicleInterfaceApp;

class Truck : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Start Truck.");
    }
    public void Stop()
    {
        Console.WriteLine("Stop Truck.");
    }
}