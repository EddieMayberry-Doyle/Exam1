using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateElizaResponse(Console.ReadLine());
            CreateElizaResponse(Console.ReadLine());
            CreateElizaResponse(Console.ReadLine());
        }

        static void CreateElizaResponse(string input)
        {
            if (input.Contains("love") || input.Contains("hate"))
            {
                Console.WriteLine("I see you feel strongly about that, care to explain further?");
            }
            else if (input.Contains("my "))
            {
                string noun1 = input.Remove(0, input.IndexOf("my ") + 3);
                if (noun1.Contains(" "))
                {
                    string noun2 = noun1.Substring(0, noun1.IndexOf(" "));
                    Console.WriteLine("I see, could you tell me more about your " + noun2 + "?");
                }
                else
                {
                    Console.WriteLine("I see, could you tell me more about your " + noun1 + "?");
                }
            }
            else
            {
                Console.WriteLine("Please, go on.");
            }
        }
    }
}