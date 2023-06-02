namespace S02_caracteres;

class Program
{
    static void Main(string[] args)
    {
         for (int i = 97; i <= 122; i++)
        {
            char lettre = (char)i;
            Console.WriteLine($"{lettre} = '{lettre}'");
        }
    }
}
