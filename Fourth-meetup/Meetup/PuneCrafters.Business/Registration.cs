using PuneCrafters.Domain;

namespace PuneCrafters.Business
{
    public class Registration
    {
        public void SignupForMeetup(MeetupParticipant meetupParticipant)
        {
            DataStore.SignupForMeetup(meetupParticipant);
        }
    }
}