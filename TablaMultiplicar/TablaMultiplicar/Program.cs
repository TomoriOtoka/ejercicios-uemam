using System.ComponentModel.Design;

namespace TablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Escribe un programa en C# que pida al usuario un número y muestre su tabla de multiplicar
             * del 1 al 10.
            */

            int numeroIngresado;
            int resultado;
            bool salir = false;

            Console.WriteLine("Ingrese un numero para mostrar su tabla de multiplicar");

            do
            {
                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        resultado = numeroIngresado * i;

                        Console.WriteLine(numeroIngresado + "x" + i + " = " + resultado);
                    }

                    salir = true;
                }
                else
                {
                    Console.WriteLine("Numero no valido");
                    continue;
                }
            }
            while (!salir);
        }
    }
}
