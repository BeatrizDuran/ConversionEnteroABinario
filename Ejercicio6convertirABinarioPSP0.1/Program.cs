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
                //Escribir el dato para realizar la comparación
                num = int.Parse(Console.ReadLine());
                //Verificar que el dato ingresado anteriormente es menor a cero
                while (num < 0)
                {
                    // Verificar que sea mayor  a cero, si se cumple las dos condiciones se vuelve a 
                    // ingresar el número.
                    while (num > 9)
                    {
                        Console.WriteLine("Favor de ingresar de nuevo el número: ");
                        num = int.Parse(Console.ReadLine());
                    }// fin while
                }// fin while
                // Inicio de las comparaciones con cada numero, dependiendo si es entre el 0 y el nueve
                // se realiza despliega el resultado en binario.
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
            }// fin try
            // Si el usuario ingresa un dato que no sea numerico como letra o decimal se despliega
            // en pantalla que el formato es incorrecto.
            catch (FormatException error)
            {
                Console.WriteLine(error.ToString());
            } // fin catch
            Console.ReadKey();
        }
    }
}
