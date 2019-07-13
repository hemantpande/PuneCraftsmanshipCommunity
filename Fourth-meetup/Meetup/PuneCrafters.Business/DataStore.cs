using System.Collections.Generic;
using PuneCrafters.Domain;

namespace PuneCrafters.Business
{
    public static class DataStore
    {
        static DataStore()
        {
            users.Add(new User
            {
                Email = "John@Doe.com",
                Id = 100,
                LocationId = 1122,
                Name = "John Doe",
                Phone = "9970123233",
                Role = GlobalConstants.ORGANIZER_ROLE
            });
            users.Add(new User
            {
                Email = "Jane@Doe.com",
                Id = 200,
                LocationId = 3344,
                Name = "Jane Doe",
                Phone = "7731962462",
                Role = GlobalConstants.PARTICIPANT_ROLE
            });
        }

        private static List<Meetup> meetups = new List<Meetup>();
        private static List<User> users = new List<User>();

        public static void CreateMeetup(Meetup meetup)
        {
            meetups.Add(meetup);
        }

        public static IEnumerable<Meetup> GetMeetups()
        {
            return meetups;
        }

        public static User GetOrganizer()
        {
            return users.Find(x => x.Role == GlobalConstants.ORGANIZER_ROLE);
        }

        public static User GetParticipant()
        {
            return users.Find(x => x.Role == GlobalConstants.PARTICIPANT_ROLE);
        }
    }
}