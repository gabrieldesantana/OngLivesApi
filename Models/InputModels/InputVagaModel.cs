using ONGLIVES.API.Entidades;

public class InputVagaModel 
{

        // public Ong? Ong { get; private set; }
        // public Voluntario? Voluntario { get; private set; }
        
        public int VoluntarioId { get; set; }
        public int OngId { get; set; }
        public string? Tipo { get; set; }
        public string? Turno { get; set; }
        public string? Descricao { get; set; }
        public string? Habilidade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
}