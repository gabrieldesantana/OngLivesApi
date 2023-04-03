namespace ONGLIVES.API.Entidades
{
    public class Ong : Base
    {
        // public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? AreaAtuacao { get; set; }
        public int QuantidadeEmpregados { get; set; }
        public int FinanceiroId { get; set; }
        public OngFinanceiro? Financeiro { get; private set; } //

        public Endereco? Endereco { get; set; }
    }
}