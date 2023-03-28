using System;

namespace _28._03Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            enterAge:
            Console.Write("Yashi daxil edin: ");
            bool isNumber = int.TryParse(Console.ReadLine(), out int age);
            if (!isNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzgun daxil edin!!");
                Console.ResetColor();
                goto enterAge;
            }
            if (age > 18 && age < 60)
            {
                Console.WriteLine("Ses vere biler");
            }
            else
            {
                Console.WriteLine("Yashiniz ses vermede istirak etmek uchun uygun deyil");
            }
        }
    }
}
