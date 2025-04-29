using System;

namespace primer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto a pagar:");
            if (!double.TryParse(Console.ReadLine(), out double monto))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                return;
            }

            // Denominaciones de billetes y monedas
            double[] denominaciones = { 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1 };

            Console.WriteLine("Desglose de billetes y monedas:");
            foreach (var denominacion in denominaciones)
            {
                int cantidad = (int)(monto / denominacion);
                monto %= denominacion;
                monto = Math.Round(monto, 2); // Evitar errores de precisión
                Console.WriteLine($"Denominación {denominacion}: {cantidad}");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
