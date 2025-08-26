namespace PrototypeProject;

// step 3
public class CarBodyPolicy : InsurancePolicyPrototype
{
    public CarBodyPolicy()
    {
        PolicyType = "Car Body Insurance";
        BasePremium = 32000000;

        Covrages = new List<string>();
        Covrages.Add("Natural Disasters"); // بلایای طبیعی
        Covrages.Add("Accident Damage"); // خسارت ناشی از تصادف
    }
    public override InsurancePolicyPrototype Clone()
    {
        return new CarBodyPolicy
        {
            PolicyType = this.PolicyType,
            BasePremium = this.BasePremium,
            Covrages = new List<string>(this.Covrages)
        };
    }
}