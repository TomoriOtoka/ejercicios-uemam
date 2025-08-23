namespace holaMundoMejorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escribe un programa en C# que pida al usuario su nombre y luego muestre en pantalla el 
             * mensaje:
             * ¡Hola [nombre], bienvenido a la programación en C#!
            */

            string nombreIngresado;

            Console.WriteLine("Ingrese su nombre");
            nombreIngresado = Console.ReadLine();

            Console.WriteLine("¡Hola" + nombreIngresado + ", bienvenido a la programación en C#?");
        }
    }
}
