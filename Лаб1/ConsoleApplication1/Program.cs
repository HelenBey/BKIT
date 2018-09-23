using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 3;
            char[] coef_name = new char[N] { 'A', 'B', 'C' };
            double[] coef = new double[N];
            double discriminant, x1, x2;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите коэффциент " + coef_name[i]);
                //coef[i] = Convert.ToDouble(Console.ReadLine());
                
                string nows = "";
                nows = Console.ReadLine();
                while (!Double.TryParse(nows, out coef[i]))
                {
                    Console.WriteLine("Некорректный ввод. Повторите еще раз");
                    nows = Console.ReadLine();
                }
            }
            discriminant = coef[1] * coef[1] - 4 * coef[0] * coef[2];
            if (discriminant < 0)
                Console.WriteLine("Нет действительных корней");
            else if (discriminant == 0)
            {
                x1 = -coef[1]/ (2 * coef[0]);
                Console.WriteLine($"X1 = X2 = {x1}");
            }
            else
            {
                x1 = (-coef[1] - Math.Sqrt(discriminant)) / (2 * coef[0]);
                x2 = (-coef[1] + Math.Sqrt(discriminant)) / (2 * coef[0]);
                Console.WriteLine($"X1  = {x1} , X2 = {x2}");
            }
        }
    }

}
