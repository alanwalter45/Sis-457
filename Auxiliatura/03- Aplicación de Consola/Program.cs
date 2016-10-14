using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Persona> lista = new Dictionary<string, Persona>();

            lista.Add("COD-1", new Persona("Ana Maria Lopez Melgar",45));
            lista.Add("COD-2", new Persona("Enrique Salty Mendez",27));
            lista.Add("COD-3", new Persona("Carmiña Mercado Andrade",38));

            foreach (var persona in lista)
            {
                Console.WriteLine("== Código: \""+persona.Key.ToString()+"\"=== Nombre: \""+persona.Value.Nombre+"\"==== Edad: "+persona.Value.Edad);
            }

            Console.Read();

        }
    }
}