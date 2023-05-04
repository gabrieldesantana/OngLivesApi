using ONGLIVES.API.Entidades;

public class EditOngModel 
{
        // public string? Nome { get; set; }
        // public string? CNPJ { get; set; }
        public int Id { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        // public string? AreaAtuacao { get; set; }
        public int QuantidadeEmpregados { get; set; }
        // public OngFinanceiro? Financeiro { get; private set; } //
        public Endereco? Endereco { get; set; }
}