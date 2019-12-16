using System;

namespace задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Введите число A, лежащие в диапазоне 1-999");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
           
            if (A>999 || A<1)
             { Console.WriteLine("Ошибка "); }

            int c = A % 2;
            if ((c == 1) && (A != 0) && (A <= 9 && A >= 1) && (A <= 99 && A > 9) && (A > 99))
            { Console.WriteLine("Число A нечётное "); }
            if ((c == 0) && (A != 0) && (A <= 9 && A >= 1) && (A <= 99 && A > 9) && (A > 99))
            { Console.WriteLine("Число A чётное "); }

            if (A>99 && A<=999)
            { Console.WriteLine("Число A трехзначное "); }
            else if (A <= 99 && A>9)
            { Console.WriteLine("Число A двузначное "); }
            else if (A<=9 && A>=1)
            { Console.WriteLine("Число A однозначное "); }
            Console.Read();
        }
    }
}
