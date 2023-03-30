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
            Experiencias = new List<Experiencia>();
        }

        public List<Voluntario> Voluntarios { get; set; }
        public List<Ong> Ongs { get; set; }
        public List<Vaga> Vagas { get; set; }
        public List<Experiencia> Experiencias { get; set; }

    }
}