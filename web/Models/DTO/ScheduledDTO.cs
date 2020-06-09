using System;
using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class scheduledDTO
    {

        public override string ToString()
        {
            return String.Format("Id={0} Type={1} Date={2} Time={3} CustomerId={4}",
                Id, Type, Date, Time, CustomerId);
        }
        
        [Required]
        public int Id { get; set; }
        
        [Required]
        public SchedulingType Type { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [Required]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        
        [Required]
        public Customer CustomerId { get; set; }
    }
}