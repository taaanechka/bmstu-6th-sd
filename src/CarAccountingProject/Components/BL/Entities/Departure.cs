#nullable disable

namespace BL
{
    public class Departure
    {
        public Departure (int id, int userId, DateTime depTime)
        {
            Id = id;
            UserId = userId;
            DepartureDate = depTime;
        }

        public int Id { get; }
        public int UserId { get; }
        public DateTime DepartureDate { get; } = DateTime.Now;

        public virtual User User { get; }
    }
}