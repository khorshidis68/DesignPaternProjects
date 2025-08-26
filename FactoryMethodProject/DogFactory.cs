namespace FactoryMethodProject;

public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}