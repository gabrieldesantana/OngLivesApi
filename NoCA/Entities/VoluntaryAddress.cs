namespace ONGLIVES.API.Entities
{
    public class VoluntaryAddress
    {
        public int VoluntaryId { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public int Number {get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}