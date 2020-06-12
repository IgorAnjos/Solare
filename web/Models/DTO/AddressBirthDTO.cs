using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace web.Models.DTO
{
    public class AddressBirthDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo data de nascimento obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        public DateTime DateOfBirth { get; set; }
        
        [Required(ErrorMessage ="Campo horário de nascimento obrigatório")]
        [Display(Name = "Horário do nascimento")]
        [DataType(DataType.Time)]
        public string BirthTime { get; set; }
        
        [Display(Name = "Cidade do nascimento")]
        [Required(ErrorMessage="Campo cidade do nascimento obrigatório")]
        public string CityBirth { get; set; }
        
        [Display(Name = "Estado do nascimento")]
        [Required(ErrorMessage="Campo estado do nascimento obrigatório")]
        public string BirthOfState { get; set; }
    }
    //public class AddressBirthDTOCollection : List<AddressBirthDTO> { }
}