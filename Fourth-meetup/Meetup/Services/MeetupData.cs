using Database;
using System;

namespace Services
{
    internal class MeetupData
    {
        internal uint Create(Guid user, string topic, string description, DateTime date, uint maxParticipants)
        {
            return MeetupDatabase.Add(user, topic, description, date, maxParticipants);
        }
    }
}