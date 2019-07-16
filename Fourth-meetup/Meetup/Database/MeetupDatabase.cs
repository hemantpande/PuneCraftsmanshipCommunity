using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Database
{
    public class MeetupDatabase
    {
        private static Dictionary<uint, Meetup> data = new Dictionary<uint, Meetup>();

        private class Meetup
        {
            internal string Topic;
            internal DateTime Date;
            internal string Description;
            internal uint MaxPax;
            internal Guid User;
        }

        public static uint Add(Guid user, string topic, string description, DateTime date, uint maxParticipants)
        {
            if (data.Any(m => m.Value.Topic == topic && m.Value.Date == date))
            {
                throw new Exception("Already exists.");
            }

            var id = (uint)data.Count;
            data.Add(id, new Meetup { User = user, Topic = topic, Description = description, Date = date, MaxPax = maxParticipants });

            return id;
        }
    }
}
