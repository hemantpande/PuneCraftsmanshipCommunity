using PuneCrafters.Domain;

namespace PuneCrafters.Business
{
    public class Scheduler
    {
        private void ScheduleMeetup(Meetup meetup)
        {
            DataStore.CreateMeetup(meetup);
        }
    }
}