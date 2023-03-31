namespace ONGLIVES.API.Entidades
{
    public class Gps : Base
    {        
        public int Latitude { get; set; }
        public int Logitude { get; set; }
        public decimal Precisao { get; set; }
        public bool Disponibilidade { get; set; }        
    }
}