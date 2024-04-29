using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinantial.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        public enum Type
        {
            Deposits,
            Debits
        }

        [Required]
        public Type CategoryType { get; set; }

        public ICollection<MoneyMovement> MoneyMovements { get; set; }

        public Category()
        {
            MoneyMovements = new Collection<MoneyMovement>();
        }
    }
}
