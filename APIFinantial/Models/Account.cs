using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFinantial.Models;

[Table("Accounts")]
public class Account
{
    [Key]
    public int AccountId { get; set; }

    [Required]
    [StringLength(100)]
    public required string Bank { get; set; }

    [Required]
    [Column(TypeName = "decimal(15,2)")]
    public double Balance { get; set; }

    public ICollection<MoneyMovement> MoneyMovements { get; set; }

    public int UserDateID { get; set; }
    public UserData OwnerAccount { get; set; }
}
