using System;
using System.Collections.Generic;
using PuneCrafters.Domain;

namespace PuneCrafters.Business
{
    public static class DataStore
    {
        private static List<Meetup> meetups = new List<Meetup>();

        private static List<User> users = new List<User>();

        static DataStore()
        {
            SetupMeetups();
            SetupUsers();
        }

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

        private static void SetupUsers()
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

        private static void SetupMeetups()
        {
            meetups.Add(new Meetup
            {
                Id = 1,
                Date = DateTime.Now.AddDays(35),
                Description = "The London Software Craftsmanship Community (LSCC) was founded with the purpose of improving and mastering the craft of software development.",
                Title = "Software Crafters North",
                ParticipantsCount = 3456,
                LocationId = 43276
            });

            meetups.Add(new Meetup
            {
                Id = 2,
                Date = DateTime.Now.AddDays(5),
                Description = "DEVDAY (https://devday.in) is a monthly informal event for developers to share their experiences, ideas, opinions & perspectives about technology.",
                Title = "DevDay Pune",
                ParticipantsCount = 21,
                LocationId = 411014
            });
        }
    }
}