namespace RestaurantWebsite.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int Guests { get; set; }
    }
}