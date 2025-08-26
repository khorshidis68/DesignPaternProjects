using PrototypeProject;

public class Program
{
    private static void Main(string[] args)
    {
        // نمونه های پایه
        var thirdPartyPrototype = new ThirdPartyPolicy();
        var carBodyPrototype = new CarBodyPolicy();

        // ایجاد بیمه نامه جدید از روی Prorotype
        var customer1Policy = thirdPartyPrototype.Clone();
        customer1Policy.BasePremium += 5000000; // افزایش نرخ برای مشتری خاص

        var customer2Policy = carBodyPrototype.Clone();
        customer2Policy.Covrages.Add("Theft Covrage"); // اضافه کردن پوشش جدید - پوشش سرقت

        Console.WriteLine($"Customer1 Policy: {customer1Policy.PolicyType}, Premium: {customer1Policy.BasePremium}, ");
        Console.WriteLine($"Customer2 Policy: {customer2Policy.PolicyType}, Covrages: {string.Join(", ",customer2Policy.Covrages)}");
    }
}