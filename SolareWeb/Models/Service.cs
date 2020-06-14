using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolareWeb.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        public bool Enabled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifieldBy { get; set; }
        public DateTime ModifieldOn { get; set; }
    }
}