using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2;
            Console.WriteLine("Введите сторону А первого треугольника");
            GetParam(out a1);
            Console.WriteLine("Введите сторону B первого треугольника");
            GetParam(out b1);
            Console.WriteLine("Введите сторону C первого треугольника");
            GetParam(out c1);
            double S1 = CalcSq(a1, b1, c1);
            bool S1Check = TriCheck(a1, b1, c1);
            Console.WriteLine("Введите сторону А второго треугольника");
            GetParam(out a2);
            Console.WriteLine("Введите сторону B второго треугольника");
            GetParam(out b2);
            Console.WriteLine("Введите сторону C второго треугольника");
            GetParam(out c2);
            double S2 = CalcSq(a2, b2, c2);
            bool S2Check = TriCheck(a2, b2, c2);
            if (S1Check == false || S2Check == false)
            {
                Console.WriteLine("Ошибка, некорректные данные для треугольников: каждая сторона должна быть меньше сумму двух других сторон");
            }
            else
            {
                if (S1 > S2)
                {
                    Console.WriteLine("Площадь первого треугольника({0:F2}) больше площади второго треугольника({1:F2})", S1, S2);
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника({0:F2}) больше площади первого треугольника({1:F2})", S2, S1);
                }
            }
            Console.ReadKey();
        }
        static void GetParam(out int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
        }
        static double CalcSq(int a, int b, int c)
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }
        static bool TriCheck(int a, int b, int c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                return false;
            }
            return true;
        }
    }
}
