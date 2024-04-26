namespace APIFinantial.Models
{
    public abstract class MoneyMovement
    {
        public required double Value { get; set; }
        public required DateOnly Date { get; set; }
        public required string Description { get; set; }
        public required Category Category { get; set; }
    }
}
