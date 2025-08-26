namespace BuilderProject;

// step 3
class Shop
{
    // Builder uses a complex series of steps
    // سازنده از یک سری مراحل پیچیده استفاده می‌کند
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildWheels();
        vehicleBuilder.BuildDoors();
    }
}