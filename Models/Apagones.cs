namespace EventosApagones.Models
{
    public class Apagones
    {
        public int Id { get; set; }
        public string? Area { get; set; }
        public string? Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadTM { get; set; }
        public int Horas { get; set; }
        public int Scrap { get; set; }
        public int GastoReparacion { get; set; }
        public int GastoTE { get; set; }
        public string? GastoOtroDesc { get; set; }
        public int? GastoOtro { get; set; }
        public string? Reporto { get; set; }
    }
}
