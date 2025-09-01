using System.Data;

namespace Arrays___Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inversión de un arreglo

            string[] nombres = new string[6];

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Console.ReadLine();
            }

            string[] nombresInversos = new string[6];

            int j = 0;
            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                nombresInversos[j] = nombres[i];
                j++;
            }

            Console.Clear();
            foreach (string nombre in  nombresInversos)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
