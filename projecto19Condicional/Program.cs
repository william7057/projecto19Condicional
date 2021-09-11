using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto19Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar 
            //un mensaje en pantalla indicando que debe abonar impuestos.

            float sueldo;
            Console.WriteLine("Ingrese su sueldo ? ");
            sueldo = float.Parse(Console.ReadLine());

            if (sueldo >3000)
            {
                Console.WriteLine("Debe abonar impuestos");
            }
            else
            {
                Console.WriteLine("No debe abonar impuestos");
            }

            Console.ReadLine();
        }
    }
}
