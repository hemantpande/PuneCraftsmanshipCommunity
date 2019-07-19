using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Registration
    {
        internal Meetup mUp;

        public void SignUp(uint meetup, User user)
        {
            if (meetup == 0)
            {
                throw new ArgumentException("Meetup is required.");
            }
            else if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            else
            {
                mUp = new MeetupData().Get(meetup);
                var ok = true;
                if (mUp.Date < DateTime.Now)
                {
                    throw new Exception("Past meetup.");
                }
                else if (mUp.Date > DateTime.Today.AddDays(10))
                {
                    if (user.Plan == MembershipPlan.Free)
                    {
                        throw new Exception("You can sign up for meetups only in the last 10 days before start. Upgrade otherwise.");
                    }
                }
                else if (mUp.Date > DateTime.Today.AddDays(30))
                {
                    if (user.Plan == MembershipPlan.Silver)
                    {
                        throw new Exception("You can sign up for meetups only in the last 30 days before start. Upgrade otherwise.");
                    }
                }

                var meetupLocation = new LocationData().GetLocation(meetup);
                int travelDistance = new LocationData().FindDistance(user.LocationId, meetupLocation);

                new MeetupData().AddParticipant(meetup, user.Id, travelDistance);
            }
        }
    }

}
