namespace AbstractMethodProject;

public class WindowsTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows TextBox.");
    }
}