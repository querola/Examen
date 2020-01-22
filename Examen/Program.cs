using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int Divisor = 2;
            int Resto = 0;
            Console.WriteLine("Digite un numero: ");
            try
            {

                while (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Favor de digitar un numero");
                }
                Resto = a % Divisor;
                if (Resto == 0)
                {
                    if (a < 100)
                    {
                        Console.WriteLine($"Es un numero par , menor a 100 y su cuadrado es { Math.Pow(a, 2)} ");

                    }
                    else
                    {
                        Console.WriteLine($"Es un numero par , Mayor a 100 y su cuadrado es {Math.Pow(a, 2)} ");
                    }
                }
                else
                {
                    if (a < 100)
                    {
                        Console.WriteLine($"No es un numero par , es menor a 100 y su cuadrado es { Math.Pow(a, 2)} ");

                    }
                    else
                    {
                        Console.WriteLine($"No es un numero par , es mayor a 100 y su cuadrado es {Math.Pow(a, 2)} ");
                    }
                }
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
