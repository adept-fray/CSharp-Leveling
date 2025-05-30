using VehicleInterfaceApp;

Console.WriteLine("Vehicle Interface App");
Console.WriteLine("Interface IVehicle with Start() and Stop().");

List<IVehicle> list = new List<IVehicle>
{
    new Car(),
    new Truck(),
    new Motorbike()
};

foreach (var vehicle in list)
{
    vehicle.Start();
}

Console.ReadKey();