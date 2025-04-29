using System;

namespace primer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto a pagar:");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                return;
            }

            // Variables para contar los billetes y monedas
            // Se inicializan a 0 para evitar problemas de precisión
            int b100 = 0, b50 = 0, b20 = 0, b10 = 0, m5 = 0, m2 = 0, m1 = 0, m05 = 0, m02 = 0, m01 = 0;

            Console.WriteLine("Desglose de billetes y monedas:");

            // Billetes de 100
            // Se usa 100 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 100)
            {
                b100 = (int)(monto / 100);
                monto -= b100 * 100;
            }

            // Billetes de 50
            // Se usa 50 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 50)
            {
                b50 = (int)(monto / 50);
                monto -= b50 * 50;
            }

            // Billetes de 20
            // Se usa 20 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 20)
            {
                b20 = (int)(monto / 20);
                monto -= b20 * 20;
            }

            // Billetes de 10
            // Se usa 10 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 10)
            {
                b10 = (int)(monto / 10);
                monto -= b10 * 10;
            }

            // Monedas de 5
            // Se usa 5 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 5)
            {
                m5 = (int)(monto / 5);
                monto -= m5 * 5;
            }

            // Monedas de 2
            // Se usa 2 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 2)
            {
                m2 = (int)(monto / 2);
                monto -= m2 * 2;
            }

            // Monedas de 1
            // Se usa 1 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 1)
            {
                m1 = (int)(monto / 1);
                monto -= m1 * 1;
            }

            // Monedas de 0.5
            // Se usa 0.5 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 0.5)
            {
                m05 = (int)(monto / 0.5);
                monto -= m05 * 0.5;
            }

            // Monedas de 0.2
            // Se usa 0.2 en lugar de 0.25 para evitar problemas de precisión
            if (monto >= 0.2)
            {
                m02 = (int)(monto / 0.2);
                monto -= m02 * 0.2;
            }

            // Monedas de 0.1
            if (monto >= 0.1)
            {
                m01 = (int)(monto / 0.1);
                monto -= m01 * 0.1;
            }

            // Redondear monto por errores de precisión
            monto = Math.Round(monto, 2);

            // Imprimir resultados
            Console.WriteLine($"Billetes de 100 soles: {b100}");
            Console.WriteLine($"Billetes de 50 soles: {b50}");
            Console.WriteLine($"Billetes de 20 soles: {b20}");
            Console.WriteLine($"Billetes de 10 soles: {b10}");
            Console.WriteLine($"Monedas de 5 soles: {m5}");
            Console.WriteLine($"Monedas de 2 soles: {m2}");
            Console.WriteLine($"Monedas de 1 sol: {m1}");
            Console.WriteLine($"Monedas de 0.5 soles: {m05}");
            Console.WriteLine($"Monedas de 0.2 soles: {m02}");
            Console.WriteLine($"Monedas de 0.1 soles: {m01}");

            if (monto > 0)
            {
                Console.WriteLine($"\nMonto restante sin cubrir (por precisión): {monto}");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
