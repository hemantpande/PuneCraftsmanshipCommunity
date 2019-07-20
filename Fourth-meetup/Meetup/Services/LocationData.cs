using System;

namespace Services
{
    public class LocationData : ILocationData
    {
        public void SetLocation(uint meetup, int locationId)
        {
            Database.LocationDatabase.SetMeetupLocation(meetup, locationId);
        }

        public int GetLocation(uint meetup)
        {
            return Database.LocationDatabase.GetMeetupLocation(meetup);
        }

        public int FindDistance(int locationId, int meetupLocation)
        {
            // Call an external service that computes the distance. Hard-coding for the session's sake.
            return new Random(5).Next(50);
        }
    }
}