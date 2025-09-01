namespace Arrays___Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Promedio de edades

            int[] edades = new int[10];

            Console.WriteLine("Ingrese 10 edades (mayor a 0)");
            for (int i = 0; i < edades.Length; i++)
            {
                do
                {
                    Console.Write("Edad " + i + ": ");
                    int.TryParse(Console.ReadLine(), out edades[i]);
                }
                while(edades[i] < 0);
            }

            int suma = 0;
            foreach (int i in edades)
            {
                suma += i;
            }
            double cantidadEdades = (double) edades.Length;
            double promedio = suma / cantidadEdades;

            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
