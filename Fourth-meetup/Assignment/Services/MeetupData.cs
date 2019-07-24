using Database;
using System;

namespace Services
{
    public class MeetupData
    {
        public uint Create(Guid user, string topic, string description, DateTime date, uint maxParticipants)
        {
            return MeetupDatabase.Add(user, topic, description, date, maxParticipants);
        }

        public Meetup Get(uint meetup)
        {
            return MeetupDatabase.Get(meetup);
        }

        public void AddParticipant(uint meetup, Guid id, int travelDistance)
        {
            MeetupParticipantDatabase.Add(meetup, id, travelDistance);
        }
    }
}