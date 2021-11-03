using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Part One */

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Weight(kg): ");
            double kg = Double.Parse(Console.ReadLine());

            Console.WriteLine("Height(cm): ");
            int cm = int.Parse(Console.ReadLine());

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"{name} is {age} years old, his weight is {kg} kg and his height is {cm} cm.");

            /* Part Two */

            double BMI = kg / (cm / 100) * (cm / 100);
            Console.WriteLine($"{name} has a BMI of {BMI}.");

        }
    }
}
