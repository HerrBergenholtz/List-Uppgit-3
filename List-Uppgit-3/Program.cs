using System;

namespace Uppgift_3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Dictionary<string, int> länder = new()
            {
                { "sverige", 450 },
                { "norge", 385 },
                { "dannmark", 43 },
                { "finland", 338 }
            };

                Console.WriteLine("Skriv in ett land.");
                Console.WriteLine("Sverige, Norge, Dannmark eller Finland");

                string nyckel = Console.ReadLine().ToLower();

                Console.WriteLine(länder[nyckel]);
            }

            catch (KeyNotFoundException)
            {
                Console.WriteLine("Du skrev inte in ett lämpligt land");
                Console.ReadKey();
                Main();
            }
            catch
            {
                Console.WriteLine("Något gick snett");
                Console.ReadKey();
                Main();
            }
        }
    }
}