using BuilderProject;

// step 7
internal class Program
{

    private static void Main(string[] args)
    {
        VehicleBuilder builder;

        // Create shop with vehicle builders
        Shop shop = new Shop();

        // Construct and display vehicles
        builder = new MotorCycleBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        builder = new CarBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        builder = new ScooterBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        Console.ReadKey();
    }

}