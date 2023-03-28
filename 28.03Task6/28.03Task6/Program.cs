using System;

namespace _28._03Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            enterNum:
            Console.Write("Ededi daxil edin: ");
            bool isInt = int.TryParse(Console.ReadLine(), out int num);
            if (!isInt)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Integer tipli deyishen daxil edin!!");
                Console.ResetColor();
                goto enterNum;
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num}*{i}= {num * i}");
            }
        }
    }
}
