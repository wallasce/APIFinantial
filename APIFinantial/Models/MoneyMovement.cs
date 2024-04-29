namespace APIFinantial.Models
{
    public abstract class MoneyMovement
    {
        public int MoneyMovementId { get; set; }
        public required double Value { get; set; }
        public required DateOnly Date { get; set; }
        public required string Description { get; set; }
        public int CategoryID { get; set; }
        public required Category Category { get; set; }

        public int AccoountID { get; set; }
        public required Account Account { get; set; }
    }
}
