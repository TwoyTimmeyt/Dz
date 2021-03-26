using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3дз
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserTry;

            Random rand = new Random();
            int gameNumber = rand.Next(12, 120);

            Console.WriteLine("Введите никнейм первого игрока");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Введите никнейм второго игрока");
            string SecondName = Console.ReadLine();  

            Console.WriteLine($"Ваше число: {gameNumber}");
            for ( ; ;)
            {
                Console.WriteLine("Ход первого игрока");
                UserTry = int.Parse(Console.ReadLine());

                if (UserTry <= 4 && UserTry > 0)
                {
                    Console.WriteLine($"Остаток после хода игрока {FirstName}: {gameNumber -= UserTry}");
                }
                else
                {
                    Console.WriteLine("Допустимо использовать только числа 1,2,3,4");
                }
                if (gameNumber == 0)
                {
                    Console.WriteLine($"Победил игрок {FirstName}, поздравляем!");
                    break;
                }

                Console.WriteLine("Ход второго игрока");
                UserTry = int.Parse(Console.ReadLine());

                if (UserTry <= 4 && UserTry > 0)
                {
                    Console.WriteLine($"Остаток после хода игрока {SecondName}: {gameNumber -= UserTry}");
                }
                else
                {
                    Console.WriteLine("Допустимо использовать только числа 1,2,3,4");
                }
                if (gameNumber == 0)
                {
                    Console.WriteLine($"Победил игрок {SecondName}, поздравляем!");
                    break;
                }
            }
        }
    }
}
