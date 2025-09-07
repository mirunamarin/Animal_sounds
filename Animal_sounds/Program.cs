using System;
using System.Collections.Generic;

namespace App1_animal_sounds
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Known animals: Dog, Cat, Cow, Duck");
            Console.Write("Choose an animal: ");
            string animal = Console.ReadLine();

            string sound;

            switch (animal)
            {
                case "Dog": sound = "woof"; break;
                case "Cat": sound = "meow"; break;
                case "Cow": sound = "moo"; break;
                case "Duck": sound = "quack"; break;
                default: sound = "(unknown animal)"; break;
            }

            Console.WriteLine($"{animal} makes sound: {sound}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}