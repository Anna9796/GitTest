class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Greet("World"));
        Console.WriteLine(GreetPerson("Alice"));
    }

    static string Greet(string name)
    {
        return $"Hello, {name}!";
    }
    static string GreetPerson(string name)
    {
        return $"Welcome, {name}!";
    }
}