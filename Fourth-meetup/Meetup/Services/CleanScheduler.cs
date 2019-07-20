using System;

namespace Services
{
    /*
     * Cleanup log:
     * Removed unused field 'valid'. Removed commented code.
     * Sequence diagram showed collaborations with MeetupData and LocationData.
     * Extract-interface refactoring for ONLY METHODS USED HERE for both collaborations done.
     * Two fields in class for interface instances.
     * A constructor that takes those two fields. Let's add a default constructor as well. Note that class still has tight coupling, but we are able to loose couple the code we are testing. Do we compile? 
     * How does the algorithm look like?
     * - If topic is null or whitespace, then an argument exception.
     * - Let us add a unit test where we discover the need for sending the argument name as part of the argument exception.
     * - Same validation for description.
     * - Date should be today or later.
     * - A hidden current behavior is that if there is no user a NullReferenceException is thrown.
     * - If membership plan is not gold or silver and participants greater than 10.
     * Behavioral tests are warranted to ensure we have all work done by our code covered - we can change to value based test later.
     */
    public class CleanScheduler
    {
        private IMeetupData meetupData;
        private ILocationData locationData;

        public CleanScheduler() : this(new MeetupData(), new LocationData())
        {
        }

        public CleanScheduler(IMeetupData meetupData, ILocationData locationData)
        {
            this.meetupData = meetupData;
            this.locationData = locationData;
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
                        throw new ArgumentException("Meetup must be today or later.", nameof(date));
                    }
                }
                else
                {
                    throw new ArgumentException("Description is required.", nameof(description));
                }
            }
            else
            {
                throw new ArgumentException("Topic is required.", nameof(topic));
            }

            if (locationId == 0)
            {
                throw new ArgumentException("A location is required.", nameof(locationId));
            }

            var id = this.meetupData.Create(user.Id, topic, description, date, maxParticipants);

            if (id == 0)
            {
                throw new Exception("Failed to create meetup.");
            }
            else
            {
                this.locationData.SetLocation(id, locationId);
            }
        }
    }
}