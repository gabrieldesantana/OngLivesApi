using ONGLIVES.API.Entities;
namespace ONGLIVES.API.Persistence.Context 
{
    public class OngLivesContext 
    {
        public OngLivesContext()
        {
            Volunteers = new List<Voluntary>();
            Institutions = new List<Institution>();
            Jobs = new List<Job>();
        }

        public List<Voluntary> Volunteers { get; set; }
        public List<Institution> Institutions { get; set; }
        public List<Job> Jobs { get; set; }
    }
}