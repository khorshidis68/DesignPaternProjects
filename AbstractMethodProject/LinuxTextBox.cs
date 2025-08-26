namespace AbstractMethodProject;

public class LinuxTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Linux TextBox");
    }
}