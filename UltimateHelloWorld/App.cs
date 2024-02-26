using HelloWorldLibrary.BusinessLogic;
using System.ComponentModel.DataAnnotations;

namespace UltimateHelloWorld;

public class App
{
    private readonly IMessages messages;

    public App(IMessages messages)
    {
        this.messages = messages;
    }
    // UltimateHelloWorld.exe -lang=es
    public void Run(string[] args)
    {
        string lang = "en";

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].ToLower().StartsWith("lang="))
            {
                lang = args[i].Substring(5);
                break;
            }
        }

        string message = messages.Greeting(lang);

        Console.WriteLine(message);
    }
}
