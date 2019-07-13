using System;

namespace PuneCrafters.Domain
{
    public class Meetup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int ParticipantsCount { get; set; }
        public int LocationId { get; set; }
    }
}
