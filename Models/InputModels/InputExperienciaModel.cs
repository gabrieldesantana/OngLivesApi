using ONGLIVES.API.Entidades;

public class InputExperienciaModel 
{

        public int Id { get; set; } //remover dps
        // public int IdVoluntario { get; set; }
        // public int IdOng { get; set; }
        public string? NomeVoluntario { get; set; }
        public string? SobrenomeVoluntario { get; set; }
        public string? NomeOng { get; set; }
        public string? ProjetoEnvolvido { get; set; }
        public string? Opiniao { get; set; }
        public DateTime DataExperienciaInicio{ get; set; }
        public DateTime DataExperienciaFim { get; set; }
        // public DateTime DataPostagem { get; set; }
}