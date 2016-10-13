using System;

namespace practica_02
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string CarnetUniversitario { get; set; }
        public string Email { get; set; }
        public bool Notificaciones { get; set; }

        public byte getEdad()
        {
            return (byte)((DateTime.Now - FechaNacimiento).Days / 365);
        }
    }
}