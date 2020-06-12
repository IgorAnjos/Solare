using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class ContactDTO
    {
        public int Id { get; set; }

        [DataType("Email")]
        public string Email { get; set; }

        [DataType("PhoneNumber")]
        public string Mobile { get; set; }
        
        [DataType("PhoneNumber")]
        public string Telephone { get; set; }
    }
    //public class ContactDTOCollection : List<ContactDTO> { }
}