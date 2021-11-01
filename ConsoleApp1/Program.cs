using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin: ");
            string surName = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + "  " + surName);
        }
    }
}
