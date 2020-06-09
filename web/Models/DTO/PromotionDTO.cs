using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class PromotionDTO
    {
        public int Id { get; set; }
        public string PromotionName { get; set; }

        [DataType("DateTime")]
        public int DateStart { get; set; }
        
        [DataType("DateTime")]
        public int DateEnd { get; set; }
    }
}