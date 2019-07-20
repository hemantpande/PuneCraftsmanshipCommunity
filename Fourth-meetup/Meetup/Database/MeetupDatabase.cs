using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Database
{
    public class Meetup
    {
        public string Topic;
        public DateTime Date;
        public string Description;
        public uint MaxPax;
        public Guid User;
    }

    public class MeetupDatabase
    {
        private static Dictionary<uint, Meetup> data = new Dictionary<uint, Meetup>();

        public static Meetup Get(uint id)
        {
            return data[id];
        }

        public static uint Add(Meetup meetup)
        {
            if (data.Any(m => m.Value.Topic == meetup.Topic && m.Value.Date == meetup.Date))
            {
                throw new Exception("Already exists.");
            }

            var id = (uint)data.Count;
            data.Add(id, meetup);

            return id;
        }
    }
}
