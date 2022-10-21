using System;
namespace Uppgift_4._25
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matte");
            string räknare = "";

            while (räknare != "3")
            {
                Console.WriteLine("Välj ett räknesätt");
                Console.WriteLine("1. Division");
                Console.WriteLine("2. Subraktion");
                Console.WriteLine("3. avsluta programmet");
                räknare = Console.ReadLine();

                switch (räknare)
                {
                    case "1":
                        Console.WriteLine("Skriv första talet");
                        int K = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv andra talet");
                        int k = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Det här är svart {K / k}");
                        break;
                    case "2":
                        Console.WriteLine("Skriv första talet");
                        int r = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv andra talet");
                        int R = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Det här är svaret {r - R}");
                        break;
                    case "3":
                        Console.WriteLine("Programmet avslutar");
                        break;
                    default:
                        Console.WriteLine("Du har inte valt någon av alternativen");
                        break;


                }

            }
        }

    }
}

