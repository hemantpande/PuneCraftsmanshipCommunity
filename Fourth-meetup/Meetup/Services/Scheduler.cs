using System;

namespace Services
{
    public class Scheduler
    {
        public void ScheduleMeetup(User user, string topic, string description, DateTime date, uint maxParticipants, int locationId)
        {
            if (user.Plan != MembershipPlan.Gold && maxParticipants > 10)
            {
                if (user.Plan != MembershipPlan.Silver)
                {
                    throw new Exception("Free plan can only have up to 10 participants.");
                }
                else if (maxParticipants > 50)
                {
                    throw new Exception("Silver plan can only have up to 50 participants.");
                }
            }

            if (string.IsNullOrWhiteSpace(topic))
            {
                throw new ArgumentException("Topic is required.");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description is required.");
            }

            if (date < DateTime.Today)
            {
                throw new ArgumentException("Meetup must be tomorrow or later.");
            }

            if (locationId == 0)
            {
                throw new ArgumentException("A location is required.");
            }

            var md = new MeetupData();
            var id = md.Create(user.Id, topic, description, date, maxParticipants);

            if (id == 0)
            {
                throw new Exception("Failed to create meetup.");
            }
            else
            {
                LocationData ld = new LocationData();
                ld.SetLocation(id, locationId);
            }
        }
    }
}
