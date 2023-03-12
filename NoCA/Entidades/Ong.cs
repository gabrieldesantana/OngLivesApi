namespace ONGLIVES.API.Entidades
{
    public class Ong : Base
    {
        // public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int QuantidadeEmpregados { get; set; }
        public Endereco Endereco { get; set; }
    }
}