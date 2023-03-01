namespace ONGLIVES.API.Entities
{
    public class Voluntary
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Schooling { get; set; }
        public string Gender { get; set; }
        public VoluntaryAddress Address { get; set; }
    }
}