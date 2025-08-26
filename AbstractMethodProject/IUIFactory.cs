namespace AbstractMethodProject;

public interface IUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}