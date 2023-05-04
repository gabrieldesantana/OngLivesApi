namespace ONGLIVES.API.Entidades
{
    public class Endereco : Base
    {
        // public int EnderecoId { get; set; }
        public string? Cep { get; set; }
        public string? EnderecoLinha { get; set; }
        public int Numero {get; set;}
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Pais { get; set; }
    }
}