using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату х точки А");
            int x = Convert.ToInt32(Console.ReadLine());//вывод х
            Console.WriteLine("Введите координату у точки А");
            int y = Convert.ToInt32(Console.ReadLine());//вывод y
            Console.WriteLine("Введите координату z точки А");
            int z = Convert.ToInt32(Console.ReadLine());//вывод z
            Console.WriteLine("Введите координату х точки B");
            int x1 = Convert.ToInt32(Console.ReadLine());//вывод х
            Console.WriteLine("Введите координату у точки B");
            int y1 = Convert.ToInt32(Console.ReadLine());//вывод y
            Console.WriteLine("Введите координату z точки B");
            int z1 = Convert.ToInt32(Console.ReadLine());//вывод z
            Console.WriteLine("Введите координату х точки C");
            int x2 = Convert.ToInt32(Console.ReadLine());//вывод х
            Console.WriteLine("Введите координату у точки C");
            int y2 = Convert.ToInt32(Console.ReadLine());//вывод y
            Console.WriteLine("Введите координату z точки C");
            int z2 = Convert.ToInt32(Console.ReadLine());//вывод z
            double l = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));
            double l1 = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2) + Math.Pow(z2 - z, 2));
            if (l < l1)
            { Console.WriteLine("Точка В ближе к А." +" "+ "Расстояние от А до В:" +  +l +"  "+"Точка В с координатами: " + "  "+ "х1=" + +x1 + "  " + "y1="+ +y1 + "  " + "z1=" + +z1); }
            else if (l1 < l)
            { Console.WriteLine("Точка C ближе к А." +" " + "Расстояние от А до C:" +  +l1 +"  "+ "Точка С с координатами: " + "  " + "х2=" + +x2 + "  " + "y2=" + +y2 + "  " + "z2=" + +z2); }
            Console.Read();
        }
    }
}
