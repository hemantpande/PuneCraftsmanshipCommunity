using System;

namespace PuneCrafters.Domain
{
    public class MeetupParticipant
    {
        public int UserId { get; set; }
        public string MeetupId { get; set; }
        public DateTime RegistrationDate { get; set; } 
    }
}
