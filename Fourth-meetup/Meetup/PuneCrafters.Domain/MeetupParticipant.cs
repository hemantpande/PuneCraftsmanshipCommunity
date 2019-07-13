using System;

namespace PuneCrafters.Domain
{
    public class MeetupParticipant
    {
        public static int NextAvailableId { get; private set; }

        public MeetupParticipant()
        {
            ++NextAvailableId;
        }

        public int UserId { get; set; }
        public int MeetupId { get; set; }
        public DateTime RegistrationDate { get; set; } 
    }
}
