using System;

namespace practica_02
{

    class Almacen
    {
        float montoCompra;

        public void Inicio()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------EJEMPLO 2---------");
            Console.WriteLine("---------------------------");
            Console.Write("INGRESE EL MONTO  DE COMPRA DEL CLIENTE:");
            montoCompra = float.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void Imprimir()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("---------EJEMPLO 2---------");
            Console.WriteLine("---------------------------");

            

            if (montoCompra > 1000)
            {
                float montoCompraOriginal = montoCompra;
                montoCompra -= montoCompra * 0.2f;
                Console.WriteLine("EL MONTO TOTAL DE COMPRA ES DE : {0} Bs. | INCLUYENDO UN DESCUENTO DE 20% POR HABER TENIDO UNA COMPRA MAYOR A Bs./1000 | MONTO ORIGINAL: {1} Bs", montoCompra,montoCompraOriginal);   
            }
            else
            {
                Console.WriteLine("EL MONTO TOTAL DE COMPRA ES DE : {0} Bs.", montoCompra);   
            }

            Console.ReadLine();            
        }


        static void Main(string[] args)
        {
            Almacen a = new Almacen();
            a.Inicio();
            a.Imprimir();
        }
    }
}