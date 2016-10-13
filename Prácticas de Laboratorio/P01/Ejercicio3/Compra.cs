using System;

namespace practica_03
{

    class Compra
    {
        int cantidadCamisas;
        float precioCamisa=55;

        public void Inicio()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------EJEMPLO 3------------------");
            Console.WriteLine("---------------------------------------------");
            Console.Write("INGRESE LA CANTIDAD DE CAMISAS  QUE COMPRÓ:");
            cantidadCamisas = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------EJEMPLO 3------------------");
            Console.WriteLine("---------------------------------------------");

            float montoCompraTotal= cantidadCamisas * precioCamisa;

            float montoCompraTotalOriginal = montoCompraTotal;

            bool exito= cantidadCamisas >= 3;
            float descuento=0;

            if (exito)
            {
                descuento = montoCompraTotal * 0.2f;
                montoCompraTotal -= descuento;
                Console.WriteLine("EL MONTO TOTAL DE COMPRA ES DE : {0} Bs.", montoCompraTotal);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
            }
            else
            {
                descuento = montoCompraTotal * 0.1f;
                montoCompraTotal -= descuento;
                Console.WriteLine("EL MONTO TOTAL DE COMPRA ES DE : {0} Bs.", montoCompraTotal);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
            }   

            Console.WriteLine(@"INCLUYENDO UN DESCUENTO DE {0}%
POR HABER TENIDO UNA COMPRA {1} A 3 CAMISAS
MONTO ORIGINAL: {2} Bs
DESCUENTO: {3} Bs", exito?"20":"10", exito?"MAYOR":"MENOR O IGUAL", montoCompraTotalOriginal, descuento);      

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Compra c = new Compra();
            c.Inicio();
            c.Imprimir();
        }

    }
}