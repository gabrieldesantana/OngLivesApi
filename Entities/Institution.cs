namespace ONGLIVES.API.Entities
{
    public class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public int AmountOfEmployee { get; set; }
        public InstitutionAddress Address { get; set; }
    }
}