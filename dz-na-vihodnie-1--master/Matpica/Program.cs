using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matpica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix mat1 = new Matrix(3, 3);
            mat1.EnterElements(); 
            Console.WriteLine(new string('-', 35));
            mat1.PrintMatrix();
            Console.WriteLine(new string('-', 35));

            mat1.EnterElements2();
            Console.WriteLine(new string('-', 35));
            mat1.PrintMatrix2(); 
            Console.WriteLine(new string('-', 35));
            /*
            mat1.Plus();
            mat1.PrintMatrix3(); 
            Console.WriteLine(new string('-', 35));
            */
            Console.Write("введите множитель: ");
            mat1.Multiply = Convert.ToInt32(Console.ReadLine());
            mat1.PrintMatrix();
            Console.WriteLine(new string('-', 35));
            /*
            Console.WriteLine("результат: ");
            mat1.Umn();
            Console.WriteLine(new String('-', 35));*/
            Console.ReadKey();
        }
    }
}
