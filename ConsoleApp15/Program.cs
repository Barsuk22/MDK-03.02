using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, x, X;
            x = 0;
            do
            {
                Console.Write("vvedite a ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("vvedite b ");
                b = Convert.ToDouble(Console.ReadLine());
            }
            while (a >= b);
            X = Zadacha(a, b, x);
            Console.WriteLine(" otvet" +
                " x = " + X);
            Console.ReadKey();
        }
        static double Zadacha(double a, double b, double x)
        {
            Double x1, x2, f1, f2, e, E,q;
            int u,w;
            
            u = 0;
            Console.WriteLine("введите сколько  чисел после запятой");
            w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vvedite tochnost' e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite shag priracheniu'");
            q = Convert.ToDouble(Console.ReadLine());   
            while (Math.Abs(b - a) > 2 * e)
            {                
                x1 = ((a + b - q) / 2);
                x1 = Math.Round(x1, w);
                x2 = ((a + b + q) / 2);
                x2 = Math.Round(x2, w);
                f1 = 3 * Math.Pow( x1, 4) + Math.Pow(x1 - 1, 2);
                f1 = Math.Round(f1, w);
                f2 =3 * Math.Pow( x2, 4) + Math.Pow(x2 - 1, 2);
                f2 = Math.Round(f2, w);               
                Console.WriteLine(" |a = " + a + "| |b = " + b + "| |x1 = " + x1 + "| |x2 = " + x2 + "| |f1 = " + f1 + "|  |f2 = " + f2 + "| ");
                if (f1 <= f2)
                    b = x1;
                else
                    a = x2;
                u++;
            }
            x = (a + b) / 2;
            x = Math.Round(x, w);
            Console.WriteLine("itteraci' " + u);
            return x;
        }
    }
}