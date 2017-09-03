using System;

namespace cnet
{
    class Program
    {
        /* 
         * `dotnet new console` — creates a new application
         * `dotnet restore` — prepare all dependencies before first run of the application
         * `dotnet run` — runs the application
         */
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name your band?");

            string name = Console.ReadLine();

            Console.WriteLine("How many people are in your band?");

            int numberOfMembers = 0;
            if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
                Console.WriteLine("input was wrong");
                Environment.Exit(0);
            }
            else
            {
                if (numberOfMembers < 1)
                {
                    Console.WriteLine("You must have at least 1 member in your band.");
                    Environment.Exit(0);
                }
                else if (numberOfMembers == 1)
                    Console.WriteLine(name + " is a solo band");
                else if (numberOfMembers == 2)
                    Console.WriteLine(name + " is a duo band");
                else
                    Console.WriteLine(name + " has " + numberOfMembers + " members.");
            }
        }
    }
}
