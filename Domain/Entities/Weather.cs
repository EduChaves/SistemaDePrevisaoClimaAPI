using Domain.Interfaces;

namespace Domain.Entities
{
    public class Weather : IBaseEntity
    {
        public int Id { get; set; }

        public string Initials { get; set; }

        public string Description { get; set; }
    }
}
