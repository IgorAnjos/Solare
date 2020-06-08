using System;

namespace web.Models
{
    public class AddressBirth
    {
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthTime { get; set; }
        public string CityBirth { get; set; }
        public string BirthOfState { get; set; }
    }
}