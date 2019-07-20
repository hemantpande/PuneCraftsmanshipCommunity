using System;
using Database;

namespace Services
{
    public class Scheduler
    {
        private IMeetupRepository _meetupRepository;

        private bool valid = false;

        public Scheduler() : this(new MeetupData())
        {
        }

        public Scheduler(IMeetupRepository meetupRepository)
        {
            _meetupRepository = meetupRepository;
        }
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
                        throw new ArgumentException("Meetup must be tomorrow or later.");
                    }
                }
                else
                {
                    valid = false;
                    throw new ArgumentException("Description is required.");
                }
            }
            else
            {
                valid = false;
                throw new ArgumentException("Topic is required.");
            }

            if (locationId == 0)
            {
                valid = false;
                throw new ArgumentException("A location is required.");
            }

            var id = _meetupRepository.Create(new Meetup
            {
                User = user.Id,
                Topic = topic,
                Description = description,
                Date = date,
                MaxPax = maxParticipants
            });

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