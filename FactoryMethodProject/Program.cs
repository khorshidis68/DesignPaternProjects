using FactoryMethodProject;

internal class Program
{
    private static void Main(string[] args)
    {
        AnimalFactory dogFactory = new DogFactory();
        var dog = dogFactory.CreateAnimal();
        dog.Sound();

        AnimalFactory catFactory = new CatFactory();
        var cat = catFactory.CreateAnimal();
        cat.Sound();
    }
}