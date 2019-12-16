using System;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C;
            Console.WriteLine("Введите число А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите число В");
            B = Convert.ToInt32(Console.ReadLine());//вывод В
            Console.WriteLine("Введите число C");
            C = Convert.ToInt32(Console.ReadLine());//вывод C
            if (A > B)
            {
                if (C > B)
                { Console.WriteLine("Сумма двух максимальных чисел:" + (A + C)); }
                else { Console.WriteLine("Сумма двух максимальных чисел:" + (A + B)); }
            }
            else if (C>A)
                { Console.WriteLine("Сумма двух максимальных чисел:" + (B + C)); }
            else { Console.WriteLine("Сумма двух максимальных чисел:" + (B + A)); }
            Console.Read();
        }
    }
}
