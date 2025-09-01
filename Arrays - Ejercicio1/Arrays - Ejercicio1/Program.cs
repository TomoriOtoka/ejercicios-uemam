using System.ComponentModel.Design;

namespace Arrays___Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = new int[5];

            Console.WriteLine("Ingrese 5 calificaciones");

            int contador = 0;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out calificaciones[contador]))
                {
                    Console.WriteLine("No valido. Ingrese un valor numerico entero");
                }
                contador++;
            }
            while (contador != 5);

            Console.Clear();
            Console.WriteLine("Calificaciones: ");
            foreach (int i in calificaciones)
            {
                Console.WriteLine(i);
            }

        }
    }
}
