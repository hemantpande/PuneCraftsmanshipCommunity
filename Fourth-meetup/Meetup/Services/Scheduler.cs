using System;

namespace Services
{
    public class Scheduler
    {
        private readonly IMeetupData _meetupData;
        private readonly ILocationData _locationData;

        public Scheduler() : this(new MeetupData(), new LocationData())
        {
        }

        public Scheduler(IMeetupData meetupData, ILocationData locationData)
        {
            _meetupData = meetupData;
            _locationData = locationData;
        }

        public void ScheduleMeetup(User user, string topic, string description, DateTime date, uint maxParticipants, int locationId)
        {
            ValidateMeetup(user, topic, description, date, maxParticipants, locationId);

            var id = _meetupData.Create(user.Id, topic, description, date, maxParticipants);

            if (id == 0)
            {
                throw new Exception("Failed to create meetup.");
            }

            _locationData.SetLocation(id, locationId);
        }

        private static void ValidateMeetup(User user, string topic, string description, DateTime date, uint maxParticipants, int locationId)
        {
            ValidateInputs(topic, description, date, locationId);

            ValidateMembership(user, maxParticipants);
        }

        private static void ValidateInputs(string topic, string description, DateTime date, int locationId)
        {
            if (string.IsNullOrWhiteSpace(topic))
            {
                throw new ArgumentException("Topic is required.", nameof(topic));
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description is required.", nameof(description));
            }

            if (date < DateTime.Today)
            {
                throw new ArgumentException("Meetup must be tomorrow or later.", nameof(date));
            }

            if (locationId == 0)
            {
                throw new ArgumentException("A location is required.", nameof(locationId));
            }
        }

        private static void ValidateMembership(User user, uint maxParticipants)
        {
            if (user.Plan == MembershipPlan.Free && maxParticipants > 10)
            {
                throw new Exception("Free plan can only have up to 10 participants.");
            }

            if (user.Plan == MembershipPlan.Silver && maxParticipants > 50)
            {
                throw new Exception("Silver plan can only have up to 50 participants.");
            }
        }
    }
}