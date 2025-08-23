using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace CajeroAutomatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Simula un cajero automático con un saldo inicial de 1000 dólares.
            * El programa debe mostrar un menú con estas opciones:
            * 1.Consultar saldo
            * 2.Depositar dinero
            * 3.Retirar dinero
            * 4.Salir
            */

            int saldo = 1000;
            string eleccion;
            bool salir = false;

            do
            {
                Console.WriteLine("Cajero automatico - Bienvenido");
                Console.WriteLine("1.Consultar saldo");
                Console.WriteLine("2.Depositar dinero");
                Console.WriteLine("3.Retirar dinero");
                Console.WriteLine("4.Salir");
                eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Su saldo es " + saldo);
                        break;
                    case "2":
                        saldo += LeerCantidad("Ingrese cantidad a depositar");
                        break;
                    case "3":
                        saldo -= LeerCantidad("Ingrese cantidad a retirar");
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("No valido.");
                        break;
                }
            }
            while (!salir);  
        }
        static public bool VerificarCantidad(int cantidad)
        {
            if (cantidad > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("La cantidad debe ser mayor a 0");
                return false;
            }
        }

        static public int LeerCantidad(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(mensaje);
            int cantidad = 0;

            if (int.TryParse(Console.ReadLine(), out cantidad))
            {
                if (VerificarCantidad(cantidad))
                {
                    return cantidad;
                }
            }
            else
            {
                Console.WriteLine("No valido.");
            }
            return 0;
        }
    }
}
