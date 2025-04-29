using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_de_la_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int unnúmeroenteropositivo;
            // Solicitar al usuario que ingrese un número entero positivo y calcule la suma de sus dígitos
            Console.WriteLine("Ingrese un número entero positivo:");
            if (!int.TryParse(Console.ReadLine(), out unnúmeroenteropositivo) || unnúmeroenteropositivo < 0)
            {
                // Validar la entrada del usuario
                Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
                return;
            }
            // Calcular la suma de los dígitos
            int suma = 0;
            while (unnúmeroenteropositivo > 0)
            {
                // Obtener el último dígito y sumarlo
                suma += unnúmeroenteropositivo % 10; // Sumar el último dígito
                unnúmeroenteropositivo /= 10; // Eliminar el último dígito
            }
            Console.WriteLine($"La suma de los dígitos es: {suma}");
            // Esperar a que el usuario presione una tecla para salir
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
}
