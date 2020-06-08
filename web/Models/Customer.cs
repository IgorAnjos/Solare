using System;

namespace web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public CustomerType CustomerType { get; set; }
        public AddressType AddressType { get; set; }
        public AddressBirth AddressBirth { get; set; }
        public Contact Contact { get; set; }
        public AddressCurrent AddressCurrent { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifieldBy { get; set; }
    }
}