using System;
using System.Collections.Generic;
using System.Text;
using Database;

namespace Services
{
    public class Registration
    {
        IMeetupData meetupData;
        
        public Registration() : this(new MeetupData())
        {

        }

        public Registration(IMeetupData meetupData)
        {
            this.meetupData = meetupData;    
        }

        public void SignUp(uint meetupId, User user)
        {
      
            if (meetupId != 0)
            {

                if (user != null)
                {
                   var meetup = meetupData.Get(meetupId);
             
                    if (meetup.Date > DateTime.Now)
                    {
                        if (user.Plan == MembershipPlan.Free && meetup.Date > DateTime.Today.AddDays(10))
                        {
                            throw new Exception("You can sign up for meetups only in the last 10 days before start. Upgrade otherwise.");
                        }

                        if ((meetup.Date < DateTime.Today.AddDays(30) && user.Plan == MembershipPlan.Silver) ||
                            user.Plan == MembershipPlan.Gold
                            )
                        {
                            var meetupLocation = new LocationData().GetLocation(meetupId);
                            int travelDistance = new LocationData().FindDistance(user.LocationId, meetupLocation);

                           meetupData.AddParticipant(meetupId, user.Id, travelDistance);
                        }
                        
                        else if (meetup.Date > DateTime.Today.AddDays(30))
                        {
                            if (user.Plan == MembershipPlan.Silver)
                            {
                                throw new Exception("You can sign up for meetups only in the last 30 days before start. Upgrade otherwise.");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Past meetup.");
                    }
                }
                else
                {
                    throw new ArgumentNullException("user");
                }
            }
            else
            {
                throw new ArgumentException("Meetup is required.");
            }
        }
    }
}