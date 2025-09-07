using System;
using System.Collections.Generic;

namespace AnimalSounds.RefactorOOP
{
    public interface IAnimal
    {
        string Type { get; }
        string Sound { get; }
    }

    public abstract class AnimalBase : IAnimal
    {
        public abstract string Type { get; }
        public abstract string Sound { get; }
        public override string ToString() => $"{Type} makes sound: {Sound}";
    }

    public sealed class Dog : AnimalBase
    {
        public override string Type => "Dog";
        public override string Sound => "woof";
    }

    public sealed class Cat : AnimalBase
    {
        public override string Type => "Cat";
        public override string Sound => "meow";
    }

    public sealed class Cow : AnimalBase
    {
        public override string Type => "Cow";
        public override string Sound => "moo";
    }

    public sealed class Duck : AnimalBase
    {
        public override string Type => "Duck";
        public override string Sound => "quack";
    }

    public sealed class Lion : AnimalBase
    {
        public override string Type => "Lion";
        public override string Sound => "roar";
    }

    public static class Program
    {
        public static void Main()
        {
            var animals = new List<IAnimal> { new Dog(), new Cat(), new Cow(), new Duck() };

            Console.WriteLine("Known animals: Dog, Cat, Cow, Duck");
            Console.Write("Choose an animal: ");
            var input = Console.ReadLine()?.Trim() ?? "";

            IAnimal found = null;
            foreach (var a in animals)
            {
                if (a.Type.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    found = a;
                    break;
                }
            }

            if (found != null)
                Console.WriteLine($"{found.Type} makes sound: {found.Sound}");
            else
                Console.WriteLine($"{input} is not a known animal.");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}