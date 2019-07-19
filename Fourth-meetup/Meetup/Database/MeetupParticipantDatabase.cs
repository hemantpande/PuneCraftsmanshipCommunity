using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Database
{
    public class MeetupParticipantDatabase
    {
        private class Participant
        {
            internal Guid Id;
            internal int WillingToTravelDistance;
            internal uint Meetup;
        }

        private static Collection<Participant> participants = new Collection<Participant>();

        public static void Add(uint meetup, Guid id, int travelDistance)
        {
            var p = new Participant { Id = id, Meetup = meetup, WillingToTravelDistance = travelDistance };
            participants.Add(p);
        }
    }
}
