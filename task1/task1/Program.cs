using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Метод. Площади треугольника
        static void Main(string[] args)
        {
           
            double firstTriangleArea = calcArea(1);
            double secondTriangleArea = calcArea(2);

            if(firstTriangleArea > secondTriangleArea)
            {
                Console.WriteLine("Площадь первого треугольника больше");
                Console.ReadKey();
            }
            if (firstTriangleArea < secondTriangleArea)
            {
                Console.WriteLine("Площадь второго треугольника больше");
                Console.ReadKey();
            }
            if (firstTriangleArea == secondTriangleArea)
            {
                Console.WriteLine("Площади треугольков равны");
                Console.ReadKey();
            }
        }
        static double calcArea(int triangle)
        {
            Console.WriteLine("Укажите длинну 1 стороны " + triangle + " треугольника (целое число)");
            int lA1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите длинну 2 стороны " + triangle + " треугольника (целое число)");
            int lB1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите длинну 3 стороны " + triangle + " треугольника (целое число)");
            int lC1 = Convert.ToInt32(Console.ReadLine());

            double pPer = (lA1 + lB1 + lC1) / 2; // Полупериметр
            double tArea = Math.Sqrt(pPer / 2 * (pPer - lA1) * (pPer - lB1) * (pPer - lC1));  // Вычисление площади по формуле Герона 

            return (tArea);
        }

    }
}
