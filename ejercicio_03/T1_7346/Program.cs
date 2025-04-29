using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_7346
{
    class Program
    {
        static void Main(string[] args)
        {    //Si el sueldo de un empleado es 1500 o menos entonces se le descuenta el 10%.
             //Si está entre 1500 y 3000 el 5 % sobre el adicional
             //y si está arriba de 3000, el 3 % sobre el adicional.
             //Escriba un algoritmo que lea el sueldo y muestre el salario neto y el impuesto
            int Sueldo;
            int descuento1;
            int adicional1, adicional2;
            Console.WriteLine("Ingrese sueldo para su sulasario neto e impuesto");
            Console.WriteLine("De cuanto es su sueldo");
            Sueldo = int.Parse(Console.ReadLine());

            if (Sueldo <= 1500)
            {

                descuento1 = (int)(Sueldo * 0.10);

                Console.WriteLine("A su sueldo de: "+ Sueldo);
                Console.WriteLine("Sueldo neto: " + (Sueldo - descuento1) + "  Impuesto: " + descuento1);
            }

            if (Sueldo>1500 && Sueldo < 3000)
            {
                adicional1 = (int)(Sueldo * 0.05 );

                Console.WriteLine("A su sueldo de: " + Sueldo);
                Console.WriteLine("Sueldo neto: " + (Sueldo - adicional1) + "   Impuesto: " + adicional1);


            }
            else if (Sueldo > 3000)
            {
                adicional2 = (int)(Sueldo * 0.03);

                Console.WriteLine("A su sueldo de: " + Sueldo);
                Console.WriteLine("Sueldo neto: " + (Sueldo - adicional2) + "   Impuesto: " + adicional2);

            }

        }
    }
}

