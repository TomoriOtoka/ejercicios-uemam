namespace calculadoraDeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crea un programa en C# que pida al usuario el año de nacimiento y calcule su edad actual
             * (suponiendo que estamos en el año 2025). Muestra el resultado en pantalla.
             */

            const int AÑO_ACTUAL = 2025;
            int añoNacimiento;
            int edad;

            Console.WriteLine("Ingrese su año de nacimiento");
            if (int.TryParse(Console.ReadLine(), out añoNacimiento))
            {
                edad = AÑO_ACTUAL - añoNacimiento;

                Console.WriteLine("Su edad es " + edad);
            }
            else
            {
                Console.WriteLine("Año no valido");
            }
        }
    }
}
