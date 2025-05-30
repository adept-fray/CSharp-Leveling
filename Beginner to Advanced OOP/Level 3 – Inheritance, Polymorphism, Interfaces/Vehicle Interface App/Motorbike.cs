namespace VehicleInterfaceApp;

class Motorbike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Start Motorbike.");
    }
    public void Stop()
    {
        Console.WriteLine("Stop Motorbike.");
    }
}