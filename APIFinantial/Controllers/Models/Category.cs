namespace APIFinantial.Controllers.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }

        public enum Type
        {
            Deposits,
            Debits
        }

        public Type CategoryType { get; set; }
    }
}
