using System;
namespace Uppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int antalHeltal = int.Parse(Console.ReadLine());
            int[] tal = new int[antalHeltal];
            Console.WriteLine("Skriv in "+antalHeltal+" heltal");
            for (int i = 0; i < antalHeltal; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Här är talen du skrev in");
            for (int i = 0; i < antalHeltal; i++)
            {
                Console.WriteLine("Tal "+(i+1)+": " + tal[i]);
            }
            Console.ReadKey();
        }
    }
}