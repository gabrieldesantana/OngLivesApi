namespace ONGLIVES.API.Entidades
{
    public class Vaga : Base
    {
        //public int Id { get; set; }
        public int VoluntarioId { get; set; }
        public Voluntario Voluntario { get; set; }
        public int OngId { get; set; }
        public Ong Ong { get; set; }

        public string Tipo { get; set; }
        public string Turno { get; set; }
        public string Descricao { get; set; }
        public string Habilidade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}