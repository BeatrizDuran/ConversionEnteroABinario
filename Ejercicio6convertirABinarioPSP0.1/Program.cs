using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6convertirABinarioPSP0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("SISTEMA QUE PERMITE LA CONVERSIÓN DE NUMEROS ");
            Console.WriteLine("HA NUMEROS BINARIOS DEL 0-9 .");
            Console.WriteLine("");
            Console.WriteLine("Favor de ingresar el número a convertir:");
            try
            {
                num = int.Parse(Console.ReadLine());
                while (num < 0)
                {
                    while (num > 9)
                    {
                        Console.WriteLine("Favor de ingresar de nuevo el número: ");
                        num = int.Parse(Console.ReadLine());
                    }
                }
            if (num == 0)
                Console.WriteLine("Su número es: " + num + ", en binario: 0000");
            if (num == 1)
                Console.WriteLine("Su número es: " + num + ", en binario: 0001");
            if (num == 2)
                Console.WriteLine("Su número es: " + num + ", en binario: 0010");
            if (num == 3)
                Console.WriteLine("Su número es: " + num + ", en binario: 0011");
            if (num == 4)
                Console.WriteLine("Su número es: " + num + ", en binario: 0100");
            if (num == 5)
                Console.WriteLine("Su número es: " + num + ", en binario: 0101");
            if (num == 6)
                Console.WriteLine("Su número es: " + num + ", en binario: 0110");
            if (num == 7)
                Console.WriteLine("Su número es: " + num + ", en binario: 0111");
            if (num == 8)
                Console.WriteLine("Su número es: " + num + ", en binario: 1000");
            if (num == 9)
                Console.WriteLine("Su número es: " + num + ", en binario: 1001");
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.ToString());
            }
            Console.ReadKey();
        }
    }
}
