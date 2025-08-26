namespace BuilderProject;

// step 2
abstract class VehicleBuilder
{
    protected Vehicle vehicle;

    public Vehicle Vehicle
    {
        get { return vehicle; }
    }

    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels(); // چرخ‌ها
    public abstract void BuildDoors();
}