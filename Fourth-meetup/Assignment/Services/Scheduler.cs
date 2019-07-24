using System;

namespace Services
{
    public class Scheduler
    {
        private bool valid = false;
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
                                valid = false;
                                throw new Exception("Free plan can only have up to 10 participants.");
                            }
                            else if (maxParticipants > 50)
                            {
                                valid = false;
                                throw new Exception("Silver plan can only have up to 50 participants.");
                            }
                        }
                    }
                    else
                    {
                        valid = false;
                        throw new ArgumentException("Meetup must be today or later.", nameof(date));
                    }
                }
                else
                {
                    valid = false;
                    throw new ArgumentException("Description is required.", nameof(description));
                }
            }
            else
            {
                valid = false;
                throw new ArgumentException("Topic is required.", nameof(topic));
            }

            if (locationId == 0)
            {
                valid = false;
                throw new ArgumentException("A location is required.", nameof(locationId));
            }

            var md = new MeetupData();
            var id = md.Create(user.Id, topic, description, date, maxParticipants);

            //var data = new LocationData();
            //data.SetLocation(id, locationId);

            if (id == 0)
            {
                throw new Exception("Failed to create meetup.");
            }
            else
            {
                var loc = new LocationData();
                loc.SetLocation(id, locationId);
            }

            valid = true;
        }
    }
}