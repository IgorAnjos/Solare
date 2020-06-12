using System;
using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class CustomerDTO
    {
        
        // public override string ToString()
        // {
        //     return String.Format(
        //         "Id={0} FullName={1} CustomerType={2} AddressBirth={3} Contact={4} AddressCurrent={5} CreatedBy={6} CreatedOn={7} ModifieldBy={8}",
        //         Id, FullName, Type, AddressBirthID, ContactID, AddressCurrentID, CreatedBy, CreatedOn, ModifieldBy);
        // }
        
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Campo Nome completo obrigatório")]
        [StringLength(300, ErrorMessage="Nome completo suporta no máximo 300 caracteres")]
        [MinLength(2,ErrorMessage="Nome completo precisa ter no mínimo 2 caracteres")]
        [Display(Name = "Nome completo")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Campo Tipo obrigatório")]
        [EnumDataType(typeof(CustomerType))] 
        public CustomerType Type { get; set; }
        
        [Required]
        public int AddressBirthID { get; set; }
        public int ContactID { get; set; }
        public int AddressCurrentID { get; set; }
        public DateTime CreatedBy { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name="Data de criação")]
        public DateTime CreatedOn { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name="Data de modificação")]
        public DateTime ModifieldBy { get; set; }
    }
}