using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void main(string[] args)
        {
            List<string> points = new List<string>();
            Console.WriteLine("Брой точки:");
            string a = Console.ReadLine();
            int number = int.Parse(a);

            Console.WriteLine("Кординати за х и у (раздели със спейс):");
            for (int i = 0; i < number; i++)
            {
                points.Add(Console.ReadLine());
            }

            double diameter = 0;
            for (int i = 1; i < points.Count - 1; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    if (i == j || i == j - 1 || i == j + 1)
                    {
                        continue;
                    }
                    else
                    {
                        int[] xy = points[i].Split().Select(int.Parse).ToArray();
                        int[] xy0 = points[j].Split().Select(int.Parse).ToArray();
                        int x = xy0[0] - xy[0];
                        int y = xy0[1] - xy[1];
                        double lenght = Math.Sqrt(x * x + y * y);
                        if (lenght > diameter)
                        {
                            diameter = lenght;
                        }
                    }

                }
            }
            Console.WriteLine($"Най-дългият диаметър = {diameter}");
            Console.ReadLine();
        }
    }
}
