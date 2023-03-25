using ONGLIVES.API.Entidades;
namespace ONGLIVES.API.Persistence.Context 
{
    public class OngLivesContext
    {
        public OngLivesContext()
        {
            Voluntarios = new List<Voluntario>();
            Ongs = new List<Ong>();
            Vagas = new List<Vaga>();
        }

        public List<Voluntario> Voluntarios { get; set; }
        public List<Ong> Ongs { get; set; }
        public List<Vaga> Vagas { get; set; }
    }
}