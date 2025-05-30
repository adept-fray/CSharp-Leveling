namespace VehicleInterfaceApp;

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Start Car.");
    }
    public void Stop()
    {
        Console.WriteLine("Stop Car.");
    }
}