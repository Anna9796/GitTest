class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Greet("World"));
    }

    static string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}