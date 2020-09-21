using System;

namespace SänkaSkepp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] game = new string[6,6];
            Random random = new Random();

            foreach (var item in game)
            {
                
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{game[i, 0]}{game[i, 1]}{game[i, 2]}{game[i, 3]}{game[i, 4]}{game[i, 5]}");
            }
            int x = random.Next(0, 6);
            int y = random.Next(0, 6);

            Console.WriteLine("Ange ett x-värde och ett y-värde för att sänka skeppet (notera att första poition är 0,0).");
            Console.Write("X-värde: ");
            int xTry = int.Parse(Console.ReadLine());
            Console.Write("Y-värde: ");
            int yTry = int.Parse(Console.ReadLine());

            if (xTry==x && yTry==y)
            {
                game[x, y] = " | ";
                Console.WriteLine("Grattis! Du träffade skeppet!");
            }
            else
            {
                game[xTry, yTry] = " * ";

            }
        }
    }
}
