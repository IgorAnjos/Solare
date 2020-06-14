using System;

namespace SolareWeb.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string PromotionName { get; set; }
        public int DateStart { get; set; }
        public int DateEnd { get; set; }
        public bool Enabled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifieldBy { get; set; }
        public DateTime ModifieldOn { get; set; }
    }
}