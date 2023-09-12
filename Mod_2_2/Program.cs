using System;

namespace Mod_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину квадрата:");
            int a = Convert.ToInt32(Console.ReadLine());
            int P = a + a + a + a;
            Console.WriteLine("Периметр квадрата равен: " + P);
        }
    }
}
