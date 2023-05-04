using ONGLIVES.API.Entidades;

public class InputVoluntarioModel 
{

        public int Id { get; set; } //remover dps

        public string? Escolaridade { get; set; }
        public string? Genero { get; set; }
        public string? Email { get; set; }
        public string? Telefone {get; set;}
        public string? Habilidade { get; set; } //
        public double Avaliacao {get; set;} //
        public int HorasVoluntaria { get; set; } //
        public int QuantidadeExperiencias { get; set; } //

        public Endereco? Endereco { get; set; }
}