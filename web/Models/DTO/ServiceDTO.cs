using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class ServiceDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(300, ErrorMessage="Nome do serviço suporta no máximo 300 caracteres")]
        public string ServiceName { get; set; }

        [DataType("Currency")]
        public decimal Price { get; set; }

        public Promotion Promotion { get; set; }
    }
}