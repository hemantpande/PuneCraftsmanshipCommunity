using System;

namespace Services
{
    internal class LocationData
    {
        public LocationData()
        {
        }

        internal void SetLocation(uint id, int locationId)
        {
            Database.LocationDatabase.SetMeetupLocation(id, locationId);
        }
    }
}