namespace PrototypeProject;

// step 1
public abstract class InsurancePolicyPrototype
{
    public string PolicyType { get; set; }
    public decimal BasePremium { get; set; }
    public List<string> Covrages { get; set; }

    public abstract InsurancePolicyPrototype Clone();
}