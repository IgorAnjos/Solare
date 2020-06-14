using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolareWeb.Models
{
    public class ServiceLocation
    {
        public int Id { get; set; }
        public string ServiceLocationName { get; set; }
        public bool Enable { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifieldBy { get; set; }
        public DateTime ModifieldOn { get; set; }
    }
}
