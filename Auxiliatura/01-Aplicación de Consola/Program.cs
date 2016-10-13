using System;
using System.Threading;

namespace Demo01_ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cuantos segundos deseas esperar?");
            byte segundos = byte.Parse(Console.ReadLine());

            if (segundos < 1 || segundos > 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento no podemos administrar la cantidad de seg. asignado :(");
                Console.WriteLine("<Presione una tecla para finalizar>");
                Console.ReadLine();
                return;
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Esperemos juntos :)");

            for (byte i = 0; i < segundos; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Esperando => " + (i + 1) +" seg.");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gracias por tu ayuda :)");

            Console.WriteLine("<Presione una tecla para finalizar>");
            Console.ReadLine();
        }
    }
}