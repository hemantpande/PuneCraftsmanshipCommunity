using System;

namespace PuneCrafters.Business
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
