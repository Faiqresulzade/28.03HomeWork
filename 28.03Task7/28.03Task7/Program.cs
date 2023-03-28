using System;

namespace _28._03Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = "faigrasul";
            Console.Write("Parol daxil edin: ");
            string pass = Console.ReadLine();
            while (passWord!=pass)
            {
                Console.Write("Parol daxil edin: ");
                 pass = Console.ReadLine();
            }

            Console.WriteLine("Xosh Gelmisiz");
        }
    }
}
