namespace APIFinantial.Models;

public class Account
{
    public int AccountId { get; set; }
    public required string Bank { get; set; }
    public double Balance { get; set; }

    public ICollection<MoneyMovement> MoneyMovements { get; set; }

    public int UserDateID { get; set; }
    public UserData OwnerAccount { get; set; }
}
