using ONGLIVES.API.Entidades;

public class OngFinanceiro : Base
{
    public int IdOng {get; set;}
    public string Tipo { get; set; }
    public DateTime Data{ get; set; }
    public decimal Valor { get; set; }
    public string Origem { get; set; }
}