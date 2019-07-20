using System;
using Database;

namespace Services
{

    public interface IMeetupRepository
    {
        void AddParticipant(uint meetup, Guid id, int travelDistance);

        uint Create(Meetup meetup);

        Meetup Get(uint meetup);
    }

    public class MeetupData : IMeetupRepository
    {
        public void AddParticipant(uint meetup, Guid id, int travelDistance)
        {
            MeetupParticipantDatabase.Add(meetup, id, travelDistance);
        }

        public uint Create(Meetup meetup)
        {
            return MeetupDatabase.Add(meetup);
        }

        public Meetup Get(uint meetup)
        {
            return MeetupDatabase.Get(meetup);
        }
    }
}