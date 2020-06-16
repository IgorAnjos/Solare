using System;

namespace SolareWeb.Models
{
    public class Scheduled
    {
        public int Id { get; set; }
        public SchedulingType Type { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifieldBy { get; set; }
        public DateTime ModifieldOn { get; set; }
        
        // public int MyProperty { get; set; } Atendido por
    }
}