namespace ParEImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crea un programa en C# que pida al usuario un número entero positivo N y muestre todos
             * los números del 1 al N, indicando si son pares o impares.
             */
            int numeroIngresado;

            Console.WriteLine("Ingrese un numero entero positivo");

            do
            {
                int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            while (numeroIngresado <= 0);

            for (int i = 1; i <= numeroIngresado; i++)
            {
                if (i  % 2 == 0)
                {
                    Console.WriteLine(i + " Par");
                }
                else
                {
                    Console.WriteLine(i + " Impar");
                }
            }
        }
    }
}
