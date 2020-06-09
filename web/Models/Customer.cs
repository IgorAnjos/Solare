using System;

namespace web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public CustomerType Type { get; set; }
        public AddressBirth AddressBirth { get; set; }
        public Contact Contact { get; set; }
        public AddressCurrent AddressCurrent { get; set; }
        public bool Enable { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifieldBy { get; set; }
        public DateTime ModifieldOn { get; set; }
    }
}