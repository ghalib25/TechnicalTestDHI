namespace DataModel
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
    }
}