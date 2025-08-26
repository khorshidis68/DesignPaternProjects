namespace PrototypeProject;

// step 2
public class ThirdPartyPolicy : InsurancePolicyPrototype
{
    public ThirdPartyPolicy()
    {
        PolicyType = "Third Party Insurance";
        BasePremium = 25000000;

        Covrages = new List<string>();
        Covrages.Add("Body Injury"); // آسیب بدنی
        Covrages.Add("Property Damage"); // خسارت به اموال
    }

    public override InsurancePolicyPrototype Clone()
    {
        return new ThirdPartyPolicy
        {
            PolicyType = this.PolicyType,
            BasePremium = this.BasePremium,
            Covrages = new List<string>(this.Covrages)
        };
    }
}