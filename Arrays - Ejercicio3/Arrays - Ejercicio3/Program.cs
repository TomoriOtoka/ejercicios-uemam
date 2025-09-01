namespace Arrays___Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Número mayor y menor

            int[] numeros = new int[8];

            int.TryParse(Console.ReadLine(), out numeros[0]);
            int numeroMayor = numeros[0];
            int numeroMenor = numeros[0];

            for (int i = 1; i < 8; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                
                if (numeros[i] < numeroMenor)
                {
                    numeroMenor = numeros[i];
                }
                if (numeros[i] > numeroMayor)
                {
                    numeroMayor = numeros[i];
                }
            }

            Console.WriteLine("Numero mayor: " + numeroMayor);
            Console.WriteLine("Numero menor: " + numeroMenor);
        }
    }
}
