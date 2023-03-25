namespace ONGLIVES.API.Entidades
{
    public class Gps : Base
    {        
        public int latitude { get; set; }
        public int logitude { get; set; }
        public decimal precisao { get; set; }
        public bool disponibilidade { get; set; }        
    }
}