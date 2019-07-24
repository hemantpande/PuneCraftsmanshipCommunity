using System;
using Database;

namespace Services
{
    public interface IMeetupData
    {
        uint Create(Guid user, string topic, string description, DateTime date, uint maxParticipants);
    }
}