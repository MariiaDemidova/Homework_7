using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ребро куба");
            int a = Convert.ToInt32(Console.ReadLine());
            int S, V;
            CalcCube(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба = {0}, объем куба = {1}", S, V);
            Console.ReadKey();
        }
        static void CalcCube(int x, out int S, out int V)
        {
            S = 6 * x * x;
            V = (int)Math.Pow(x, 3);
        }
    }
}
