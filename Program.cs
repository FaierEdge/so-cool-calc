using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calc";
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию (+, -): ");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                double result = a + b;
                Console.WriteLine($"{a} + {b} = {result}");
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadKey();
        }
    }
}
