using System;
using static Critter.Critter;

namespace Critter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Critter game!");

            Console.Write("Choose a critter type (Cat or Dog): ");
            string critterType = Console.ReadLine();

            Console.Write("Enter a name for your critter: ");
            string critterName = Console.ReadLine();

            Critter critter;

            if (string.Equals(critterType, "Cat", StringComparison.OrdinalIgnoreCase))
            {
                critter = new Cat(critterName);
            }
            else if (string.Equals(critterType, "Dog", StringComparison.OrdinalIgnoreCase))
            {
                critter = new Dog(critterName);
            }
            else
            {
                Console.WriteLine("Invalid critter type. Defaulting to a generic Critter.");
                critter = new Critter(critterName);
            }

            while (critter.GetAlive())
            {
                Console.WriteLine($"What would you like {critterName} to do?");
                string lineRead = Console.ReadLine();
                if (lineRead.Equals("eat", StringComparison.OrdinalIgnoreCase))
                {
                    critter.Eat();
                }
                else if (lineRead.Equals("sleep", StringComparison.OrdinalIgnoreCase))
                {
                    critter.Sleep();
                }
                else if (lineRead.Equals("exercise", StringComparison.OrdinalIgnoreCase))
                {
                    critter.Exercise();
                }
            }
            Console.WriteLine($"{critterName} has died.");
        }
    }
}
