using ONGLIVES.API.Entidades;

namespace ONGLIVES.API.VO
{
    public class VoluntarioVO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataAniversario { get; set; }
        public string Escolaridade { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}