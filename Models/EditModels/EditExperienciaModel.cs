using ONGLIVES.API.Entidades;

public class EditExperienciaModel 
{
        
        public int Id { get; set; }
        public int IdVoluntario { get; set; }
        // public string? NomeVoluntario { get; set; }
        public int IdOng { get; set; }
        // public string? NomeOng { get; set; }
        public string? ProjetoEnvolvido { get; set; }
        public string? Opiniao { get; set; }
        // public DateTime DataPostagem { get; set; }
        public DateTime DataExperienciaInicio{ get; set; }
        public DateTime DataExperienciaFim { get; set; }
}