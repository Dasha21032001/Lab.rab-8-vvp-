using System;

namespace лаб.раб__8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введите А");
            A = Convert.ToInt32(Console.ReadLine());//вывод А
            Console.WriteLine("Введите В");
            B = Convert.ToInt32(Console.ReadLine());//вывод В
            if (A == B)
            {
                A = 0;
                B = 0;   
            }

            if (A != B)
            {
                if (A < B)
                    A = B;
            }
            else
            {
                 B= A;
            }

            Console.WriteLine("Новое значение А" + A);
            Console.WriteLine("Новое значение B" + A);
            Console.Read();
        }
    }
}
