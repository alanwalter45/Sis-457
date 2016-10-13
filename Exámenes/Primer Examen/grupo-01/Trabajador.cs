namespace grupo_01
{
    class Trabajador
    {
        public string NombreCompleto { get; set; }
        public float HorasTrabajadas { get; set; }
        public float TarifaPorHora { get; set; }

        public float getMontoTotal()
        {
            return HorasTrabajadas * TarifaPorHora;
        }

        public override string ToString()
        {
            return string.Format(@"Nombre Completo:{0} | Monto Original:{1}",NombreCompleto ,getMontoTotal());
        }
    }
}