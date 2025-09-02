namespace AdapterProject;

// step 4

// اینترفیس مورد انتظار سیستم شما
public interface IPersonService
{
    Person GetPerson(Guid nationalCode);
}