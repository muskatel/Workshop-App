namespace BasicApp;

class Program
{
    static void Main(string[] args)
    {
        PrintHello();
        PrintHello("Craig");
    }

    static void PrintHello(string name = "World!")
    {
        Console.WriteLine("Hello, {name}!");
    }
}