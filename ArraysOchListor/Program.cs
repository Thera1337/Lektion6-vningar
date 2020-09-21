using System;

namespace ArraysOchListor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Ange valfritt namn: ");
                string name = Console.ReadLine();
                names[i] = name;
            }

            Array.Reverse(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Ange vilken plats i listan som du vill byta namn på: ");
            int choise = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Ange namnet du vill byta till: ");
            string newName = Console.ReadLine();

            names[choise] = newName;
        }
    }
}
