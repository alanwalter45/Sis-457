namespace ConsoleApplication1
{
    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Persona(string nombre, byte edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}