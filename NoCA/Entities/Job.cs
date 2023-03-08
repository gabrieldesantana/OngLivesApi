namespace ONGLIVES.API.Entities
{
    public class Job : BaseEntity
    {
        //public int Id { get; set; }
        public int VoluntaryId { get; set; }
        public Voluntary Voluntary { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }

        public string Type { get; set; }
        public string WorkShift { get; set; }
        public string Description { get; set; }
        public string Skill { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime FinishAt { get; set; }
    }
}