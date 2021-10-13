using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesterenko
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Введите с: ");
                float c = float.Parse(Console.ReadLine());

                Console.WriteLine(new string('-', 40));


                NesterenkoLog.I().Log($"{a}^2 + {b}x + {c} = 0");
                NesterenkoLog.I().Log("Корни уравнения: " + string.Join(", ", new QuadraticEquation().Solve(a, b, c)));

            }
            catch (NesterenkoException ex)
            {
                NesterenkoLog.I().Log("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                NesterenkoLog.I().Log("Ошибка: " + ex.Message);
            }

            NesterenkoLog.I().Write();

            Console.ReadKey();
        }
    }
}
