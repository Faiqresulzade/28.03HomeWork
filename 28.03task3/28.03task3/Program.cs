using System;

namespace _28._03task3
{
    class Program
    {
        static void Main(string[] args)
        {
            enterNum:
            Console.Write("Ededi daxil edin: ");
            bool isExist = int.TryParse(Console.ReadLine(), out int number);
            if (!isExist)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("reqemi duzgun daxil edin!!");
                Console.ResetColor();
                goto enterNum;
            }
            if (number > 0)
            {
                Console.WriteLine("eded musbetdir");
            }else if (number < 0)
            {
                Console.WriteLine("eded menfidir ");
            }
            else
            {
                Console.WriteLine($"eded {number}-dir");
            }
        }
    }
}
