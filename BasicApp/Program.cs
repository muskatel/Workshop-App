namespace BasicApp;

class Program
{
    static void Main(string[] args)
    {
        PrintMessage();
        PrintMessage("Craig");
    }

    static void PrintMessage(string name = "World!")
    {
        Console.WriteLine("Hello, {name}!");
        Console.WriteLine("Thank you for using our software ❤️");
    }
}