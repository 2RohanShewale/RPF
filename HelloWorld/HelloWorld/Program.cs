// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            int val = 7;
            double val1 = 345.5;
            Console.WriteLine("Write you name? ");
            string username = Console.ReadLine();

            Console.WriteLine("Hello, World! "+val);
            Console.WriteLine(username);
        }
    }
}