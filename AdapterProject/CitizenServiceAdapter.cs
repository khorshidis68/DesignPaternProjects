namespace AdapterProject;

// step 5

// Adapter: سرویس خارجی رو به سیستم شما متصل می‌کنه
public class CitizenServiceAdapter : IPersonService
{
    private readonly ExternalCitizenService _externalCitizenService;

    public CitizenServiceAdapter(ExternalCitizenService externalCitizenService)
    {
        _externalCitizenService = externalCitizenService;
    }

    public Person GetPerson(Guid nationalCode)
    {
        var citizen = _externalCitizenService.FetchCitizen(nationalCode.ToString());

        return new Person
        {
            FirstName = citizen.Name,
            LastName = citizen.Family,
        };
    }
}