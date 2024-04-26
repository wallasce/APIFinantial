namespace APIFinantial.Controllers.Models;

public class Account
{
    public int AccountId { get; set; }
    public required string Bank { get; set; }
    public double Balance { get; set; }

    public List<MoneyMovement>? MoneyMovements { get; set; }

    public UserData? OwnerAccount { get; set; }
}
