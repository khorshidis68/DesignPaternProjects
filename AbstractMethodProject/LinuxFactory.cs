namespace AbstractMethodProject;

public class LinuxFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new LinuxButton();
    }

    public ITextBox CreateTextBox()
    {
        return new LinuxTextBox();
    }
}