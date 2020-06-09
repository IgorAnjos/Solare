using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace web.Models.DTO
{
    public class AddressBirthDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(300, ErrorMessage="Nome completo suporta no máximo 300 caracteres")]
        [MinLength(2,ErrorMessage="Nome completo precisa ter no mínimo 2 caracteres")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [Display(Name = "Horário do Nascimento")]
        [DataType(DataType.Time)]
        public string BirthTime { get; set; }
        
        [Display(Name = "Cidade do Nascimento")]
        [Required]
        public string CityBirth { get; set; }
        
        [Display(Name = "Estado do Nascimento")]
        [Required]
        public string BirthOfState { get; set; }
    }
}