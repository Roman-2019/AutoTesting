using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discriminant_dll;

namespace QuadraticEquation
{
    class Program
    {
        static double CheckNumber(string number)
        {
            double x;
            while (!double.TryParse(number, out x))
            {
                Console.WriteLine("The value entered is not a number!");
                Console.WriteLine("Enter the correct value:");
                number = Console.ReadLine();
            }
            return x;
        }
        static void ProverkaDeleniya(double x)
        {
            while (x == 0)
            {
                Console.WriteLine("Input value а, not equal 0!");
                x = double.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {

            var discriminant = new Discriminant();

            Console.WriteLine("Input value а, not equal 0");
            //for value а
            double a;
            string vvod_znach = Console.ReadLine();
            a = CheckNumber(vvod_znach);
            ProverkaDeleniya(a);

            //for value b
            Console.WriteLine("Введите b:");
            double b;
            vvod_znach = Console.ReadLine();
            b = CheckNumber(vvod_znach);

            //for value c
            Console.WriteLine("Введите c:");
            double c;
            vvod_znach = Console.ReadLine();
            c = CheckNumber(vvod_znach);

            var _discriminant = discriminant.CalculationDiscriminant(a,b,c);

            if (_discriminant.D < 0)
            {
                Console.WriteLine("The discriminant is D = {0} and less than 0, therefore the equation has no roots!", _discriminant.D);
            }
            else
            {
                if (_discriminant.D > 0)
                {
                    Console.WriteLine("The discriminant is D = {2} and greater than 0, therefore the equation has two roots: {0} and {1}", _discriminant.x1, _discriminant.x2, _discriminant.D);
                }
                else
                {
                    Console.WriteLine("The discriminant is D = {1}, therefore the equation has one root: {0}", _discriminant.x1, _discriminant.D);
                }
            }

            //Console.WriteLine("Разложение на линейные множители:");
            //Console.WriteLine("{0}*x*x+{1}*x+{2}={0}*(x-{3})*(x-{4})", a, b, c, x1, x2);
            Console.ReadKey();
        }
    }
}
