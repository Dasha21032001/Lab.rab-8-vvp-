using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            Console.WriteLine("Введите координату X");
            X = Convert.ToInt32(Console.ReadLine());//вывод X
            Console.WriteLine("Введите координату  Y");
            Y= Convert.ToInt32(Console.ReadLine());//вывод Y
            
                if ((X > 0) && (Y > 0))
            { Console.WriteLine("1-я четверть"); }
                else if ((X < 0) && (Y > 0))
            { Console.WriteLine("2-я четверть"); }
                else if ((X < 0) && (Y < 0))
            { Console.WriteLine("3-я четверть"); }
                else if ((X > 0) && (Y < 0))
            { Console.WriteLine("4-я четверть"); }
                else { Console.WriteLine("Ошибка"); }
            Console.Read();
        }
    }
}
