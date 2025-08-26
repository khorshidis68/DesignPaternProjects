namespace AbstractMethodProject;

public class LinuxButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Linux Button");
    }
}