using System;

namespace PuneCrafters.Domain
{
    public class MeetupParticipant
    {
        public int UserId { get; set; }
        public int MeetupId { get; set; }
        public DateTime RegistrationDate { get; set; } 
    }
}
