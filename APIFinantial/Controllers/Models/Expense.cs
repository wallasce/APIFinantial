namespace APIFinantial.Controllers.Models;

public class Expense : MoneyMovement
{
    public enum Type
    {
        Credit,
        Debit
    }

    public Type CategoryType { get; set; }
}
