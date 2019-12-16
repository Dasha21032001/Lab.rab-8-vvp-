using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Введите число A");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            if (A==0)
            { Console.WriteLine("Число A нулевое"); }
            else if (A > 0)
            { Console.WriteLine("Число A положительное "); }
            else
            { Console.WriteLine("Число A отрицательное "); }
            
            int c= A % 2;
            if ((c == 1) && (A!=0))
            { Console.WriteLine("Число A нечётное "); }
            if ((c == 0) && (A != 0))
            { Console.WriteLine("Число A чётное "); }
            Console.Read();
        }
    }
}

