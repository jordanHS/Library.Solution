namespace Library.Models
{
    public class Checkout
    {
        public int CheckoutId { get; set; }
        public int CopyId { get; set; }
        public int PatronId { get; set; }
        public Copy Copy { get; set; }
        public Patron Patron { get; set; }
    }
}