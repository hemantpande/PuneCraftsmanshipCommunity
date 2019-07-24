using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class LocationDatabase
    {
        private static Dictionary<uint, int> meetupLocations = new Dictionary<uint, int>();
        public static void SetMeetupLocation(uint id, int locationId)
        {
            meetupLocations.Add(id, locationId);
        }

        public static int GetMeetupLocation(uint meetup)
        {
            return meetupLocations[meetup];
        }
    }
}
