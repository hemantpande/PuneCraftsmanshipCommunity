using System;

namespace Services
{
    public class Scheduler
    {
        public void ScheduleMeetup(User user, string topic, string description, DateTime date, uint maxParticipants, int locationId)
        {
            if (!string.IsNullOrWhiteSpace(topic))
            {
                if (!string.IsNullOrWhiteSpace(description))
                {
                    if (date >= DateTime.Today)
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
                    }
                    else
                    {
                        throw new ArgumentException("Meetup must be tomorrow or later.");
                    }
                }
                else
                {
                    throw new ArgumentException("Description is required.");
                }
            }
            else
            {
                throw new ArgumentException("Topic is required.");
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
                var loc = new LocationData();
                loc.SetLocation(id, locationId);
            }
        }
    }
}