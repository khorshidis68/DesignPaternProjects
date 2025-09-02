using AdapterProject;

public class Program
{
    private static void Main(string[] args)
    {
        IPersonService personService = new CitizenServiceAdapter(new ExternalCitizenService());

        Person p = personService.GetPerson(Guid.NewGuid());

        Console.WriteLine($"Name: {p.FirstName} {p.LastName}");
    }
}