using System;
using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class CustomerDTO
    {
        
        public override string ToString()
        {
            return String.Format(
                "Id={0} FullName={1} CustomerType={2} AddressBirth={3} Contact={4} AddressCurrent={5} CreatedBy={6} CreatedOn={7} ModifieldBy={8}",
                Id, FullName, Type, AddressBirth, Contact, AddressCurrent, CreatedBy, CreatedOn, ModifieldBy);
        }
        
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(300, ErrorMessage="Nome completo suporta no máximo 300 caracteres")]
        [MinLength(2,ErrorMessage="Nome completo precisa ter no mínimo 2 caracteres")]
        [Display(Name = "Nome Completo")]
        public string FullName { get; set; }

        
        [EnumDataType(typeof(CustomerType))] 
        public CustomerType Type { get; set; }
        
        [Required]
        public int AddressBirthID { get; set; }
        public int ContactID { get; set; }
        public int AddressCurrentID { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifieldBy { get; set; }
    }
}