using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        // Метод. Объем и площадь поверхности куба
        static void Main(string[] args)
        {   
            cubeCalculation();            
        }

        static void cubeCalculation()
        {
            Console.WriteLine("Введите длинну ребра куба (целое число)");
            int a = Convert.ToInt32(Console.ReadLine());
            double cubeVolume = Math.Pow(a, 3);
            double cubeSurfaceArea = Math.Pow(a, 2) * 6;

            Console.WriteLine("Объем куба " + cubeVolume);
            Console.WriteLine("Площадь поверхности куба " + cubeSurfaceArea);
            Console.ReadKey();
        }
    }
}
