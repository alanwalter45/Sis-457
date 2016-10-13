using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01
{
    class Hombre
    {
        private string nombre;
        private float dinero;

        public void Inicio()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------EJEMPLO 1---------");
            Console.WriteLine("---------------------------");
            Console.Write("INGRESE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.Write("INGRESE SU MONTO DE DINERO: ");
            dinero = float.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("---------EJEMPLO 1---------");
            Console.WriteLine("---------------------------");

            Console.WriteLine("NOMBRE:  " + nombre);
                
            if(dinero>7000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("USTED NO PUEDE EXCEDER EL MONTO DE Bs./7000");
            }
            else
            {
                Console.WriteLine("INVERSIÓN: {0} Bs",dinero);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Hombre per = new Hombre();
            per.inicio();
            per.Imprimir();
        }
    }
}
