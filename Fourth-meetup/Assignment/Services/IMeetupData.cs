using System;
using Database;

namespace Services
{
    public interface IMeetupData
    {
        void AddParticipant(uint meetup, Guid id, int travelDistance);
        uint Create(Guid user, string topic, string description, DateTime date, uint maxParticipants);
        Meetup Get(uint meetup);
    }
}