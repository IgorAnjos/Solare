using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class AddressCurrentDTO
    {   
        [Required]
        public int Id { get; set; }
        
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Display(Name = "Número")]
        public string Number { get; set; }
        
        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }
        
        [Display(Name = "Bairro")]
        public string Neighborhoods { get; set; }

        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }
    }
}