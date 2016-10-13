
namespace _02_WindowsForms
{
    class Registro
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public byte EdadUsuario { get; set; }

        public Registro()
        {
            Id = this.GetHashCode();
        }
    }
}