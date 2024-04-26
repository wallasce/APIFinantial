namespace APIFinantial.Controllers.Models;

public class Expense : MoneyMovement
{
    public int ExpenseId { get; set; }
    public enum Type
    {
        Credit,
        Debit
    }

    public Type CategoryType { get; set; }
}
