namespace AdapterProject;

// step 3

public class ExternalCitizenService
{
    public CitizenInfo FetchCitizen(string code)
    {
        // فرض کن از سرویس بیرونی اطلاعات میاره
        return new CitizenInfo { 
            Name = "Ali",
            Family = "Ahmadi"
        };
    }
}