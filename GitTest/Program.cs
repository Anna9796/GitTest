class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Greet("World"));
        Console.WriteLine(Farewell("World"));
    }

    static string Greet(string name)
    {
        return $"Hello, {name}!";
    }

    static string Farewell(string name)
    {
        return $"Goodbye, {name}!";
    }
}