using System;

namespace SolareWeb.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime BirthTime { get; set; }
        public string CityBirth { get; set; }
        public string BirthOfState { get; set; }
        public bool Enable { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifieldBy { get; set; }
        public DateTime ModifieldOn { get; set; }
        //public int ContactID { get; set; }
        //public AddressCurrent AddressCurrentID { get; set; }
    }
}