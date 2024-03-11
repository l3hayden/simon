using System.ComponentModel.DataAnnotations.Schema;

namespace L3Pricing.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Sell { get; set; }
        public string Description { get; set; }
    }
}
