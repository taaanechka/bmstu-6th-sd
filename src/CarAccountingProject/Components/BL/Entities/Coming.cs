#nullable disable

namespace BL
{
    public class Coming
    {
        public Coming ( int id, int userId, DateTime comTime)
        {
            Id = id;
            UserId = userId;
            ComingDate = comTime;
        }

        public int Id { get; }
        public int UserId { get; }
        public DateTime ComingDate { get; } = DateTime.Now;

        public virtual User User { get; }
    }
}
