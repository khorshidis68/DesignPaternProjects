using AbstractMethodProject;

internal class Program
{
    private static void Main(string[] args)
    {
        // فرض کنیم کاربر محیط ویندوز را انتخاب کرده
        IUIFactory factory;

        string os = "Windows"; // یا Linux

        if (os == "Windows") {
            factory = new WindowsFactory();
        }
        else if (os == "Linux") { 
            factory = new LinuxFactory();
        }
        else
        {
            throw new Exception("Un Supported OS");
        }

        // حالا بدون دانستن نوع دقیق، اجزا را میسازیم
        var button = factory.CreateButton();
        var textBox = factory.CreateTextBox();

        button.Render();
        textBox.Render();

    }
}