using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinantial.Models
{
    public abstract class MoneyMovement
    {
        [Key]
        public int MoneyMovementId { get; set; }

        [Required]
        [Column(TypeName = "decimal(15,2)")]
        public required double Value { get; set; }

        [Required]
        public required DateOnly Date { get; set; }

        [Required]
        [StringLength(200)]
        public required string Description { get; set; }

        public int CategoryID { get; set; }
        public required Category Category { get; set; }

        public int AccoountID { get; set; }
        public required Account Account { get; set; }
    }
}
