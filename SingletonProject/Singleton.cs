using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject;

public sealed class Singleton
{
    private Singleton() { }

    private static Singleton _instance;

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }

    private string _name;
    public void SetName(string name)
    { 
        _name = name;
    }

    public void DoSomething()
    {
        Console.WriteLine("Doing Samething ...");
    }

    public void PrintName()
    {
        Console.WriteLine(_name);
    }

}