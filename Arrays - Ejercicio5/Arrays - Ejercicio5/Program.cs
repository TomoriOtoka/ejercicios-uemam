namespace Arrays___Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Busqueda de un arreglo

            string[] productos = new string[5];

            Console.WriteLine("Ingrese los nombres de los productos");

            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = Console.ReadLine();
            }

            Console.WriteLine("Ingrese un producto a buscar");

            string eleccion = Console.ReadLine();

            if(productos.Contains(eleccion))
            {
                Console.WriteLine("Si se encuentra en la eleccion");
            }
            else
            {
                Console.WriteLine("No se encuentra en la seleccion");
            }
        }
    }
}
