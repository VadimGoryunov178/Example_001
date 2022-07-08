internal class NewBaseType
{
    private static void Main(string[] args)
    {
        Console.Write("Введите ваше имя ");
        string username = Console.ReadLine();
        Console.Write("Привет, ");
        Console.Write(username);
    }
}

internal class Program : NewBaseType
{
}