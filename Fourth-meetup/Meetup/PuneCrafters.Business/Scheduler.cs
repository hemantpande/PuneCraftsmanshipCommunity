using PuneCrafters.Domain;

namespace PuneCrafters.Business
{
    public class Scheduler
    {
        public void ScheduleMeetup(Meetup meetup)
        {
            DataStore.CreateMeetup(meetup);
        }
    }
}